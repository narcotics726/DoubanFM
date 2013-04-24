using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Nark.DoubanFM.Model
{
    public class Naudio_Player : IPlayer
    {
        public Naudio_Player()
        {
            playbackState = StreamingPlaybackState.Stopped;
            timer = new Timer(TimerTick, null, Timeout.Infinite, 250);
        }

        private enum StreamingPlaybackState
        {
            Stopped,
            Playing,
            Buffering,
            Paused
        }

        private volatile StreamingPlaybackState playbackState;
        private volatile bool fullyDownloaded;
        private BufferedWaveProvider bufferedWaveProvider;
        private HttpWebRequest webRequest;
        private IWavePlayer waveOut;
        private Timer timer;
        private VolumeWaveProvider16 volumeProvider;

        private void TimerTick(object state)
        {
            if (playbackState != StreamingPlaybackState.Stopped)
            {
                if (this.waveOut == null && this.bufferedWaveProvider != null)
                {
                    //Debug.WriteLine("Creating WaveOut Device");
                    waveOut = new WaveOut();
                    waveOut.PlaybackStopped += waveOut_PlaybackStopped;
                    this.volumeProvider = new VolumeWaveProvider16(bufferedWaveProvider);
                    this.volumeProvider.Volume = 1;
                    waveOut.Init(volumeProvider);
                }
                else if (bufferedWaveProvider != null)
                {
                    var bufferedSeconds = bufferedWaveProvider.BufferedDuration.TotalSeconds;
                    // make it stutter less if we buffer up a decent amount before playing
                    if (bufferedSeconds < 0.5 && this.playbackState == StreamingPlaybackState.Playing &&
                        !this.fullyDownloaded)
                    {
                        this.playbackState = StreamingPlaybackState.Buffering;
                        waveOut.Pause();
                        //Debug.WriteLine(String.Format("Paused to buffer, waveOut.PlaybackState={0}", waveOut.PlaybackState));
                    }
                    else if (bufferedSeconds > 4 && this.playbackState == StreamingPlaybackState.Buffering)
                    {
                        waveOut.Play();
                        //Debug.WriteLine(String.Format("Started playing, waveOut.PlaybackState={0}", waveOut.PlaybackState));
                        this.playbackState = StreamingPlaybackState.Playing;
                    }
                    else if (this.fullyDownloaded && bufferedSeconds == 0)
                    {
                        //Debug.WriteLine("Reached end of stream");
                        StopPlayback();
                    }
                }
            }
        }

        private void StopPlayback()
        {
            if (playbackState != StreamingPlaybackState.Stopped)
            {
                if (!fullyDownloaded)
                {
                    webRequest.Abort();
                }
                this.playbackState = StreamingPlaybackState.Stopped;
                if (waveOut != null)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                    waveOut = null;
                }
                timer.Change(Timeout.Infinite, Timeout.Infinite);
                // n.b. streaming thread may not yet have exited
                Thread.Sleep(500);
            }
        }

        private void waveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            //
        }

        public void Play(string url)
        {
            if (playbackState == StreamingPlaybackState.Playing || playbackState == StreamingPlaybackState.Buffering)
            {
                StopPlayback();
            }
            if (playbackState == StreamingPlaybackState.Stopped)
            {
                playbackState = StreamingPlaybackState.Buffering;
                bufferedWaveProvider = null;
                ThreadPool.QueueUserWorkItem(new WaitCallback(StreamMP3), url);
                timer.Change(0, 250);
            }
        }

        private void StreamMP3(object state)
        {
            fullyDownloaded = false;
            string url = (string) state;
            webRequest = (HttpWebRequest) WebRequest.Create(url); //why HttpWebRequest instead of WebRequest
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse) webRequest.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status != WebExceptionStatus.RequestCanceled)
                {
                    throw;
                }
                return;
            }
            byte[] buffer = new byte[16384*4]; //how to calc this number?

            IMp3FrameDecompressor decompressor = null;
            try
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    var readFullyStream = new ReadFullyStream(responseStream);
                    do
                    {
                        if (bufferedWaveProvider != null &&
                            bufferedWaveProvider.BufferLength - bufferedWaveProvider.BufferedBytes <
                            bufferedWaveProvider.WaveFormat.AverageBytesPerSecond/4)
                        {
                            //buffer getting full
                            Thread.Sleep(500);
                        }
                        else
                        {
                            Mp3Frame frame;
                            try
                            {
                                frame = Mp3Frame.LoadFromStream(readFullyStream);
                            }
                            catch (EndOfStreamException)
                            {
                                fullyDownloaded = true; //file or stream reach end
                                break;
                            }
                            catch (WebException)
                            {
                                break;
                            }
                            if (decompressor == null)
                            {
                                WaveFormat format = new Mp3WaveFormat(frame.SampleRate,
                                                                      frame.ChannelMode == ChannelMode.Mono ? 1 : 2,
                                                                      frame.FrameLength, frame.BitRate);
                                decompressor = new AcmMp3FrameDecompressor(format);
                                bufferedWaveProvider = new BufferedWaveProvider(decompressor.OutputFormat)
                                    {
                                        BufferDuration = TimeSpan.FromSeconds(20)
                                    };
                            }
                            int decompressed = decompressor.DecompressFrame(frame, buffer, 0);
                            bufferedWaveProvider.AddSamples(buffer, 0, decompressed);
                        }
                    } while (playbackState != StreamingPlaybackState.Stopped);
                    decompressor.Dispose();
                }
            }
            finally
            {
                if (decompressor != null)
                    decompressor.Dispose();
            }
        }

        public void Play(System.IO.Stream stream)
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            if (playbackState == StreamingPlaybackState.Playing || playbackState == StreamingPlaybackState.Buffering)
            {
                waveOut.Pause();
                //Debug.WriteLine(String.Format("User requested Pause, waveOut.PlaybackState={0}", waveOut.PlaybackState));
                playbackState = StreamingPlaybackState.Paused;
            }
            else if (playbackState == StreamingPlaybackState.Paused)
            {
                Continue();
            }
        }

        public void Continue()
        {
            if (playbackState == StreamingPlaybackState.Paused)
            {
                playbackState = StreamingPlaybackState.Buffering;
            }
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Previous()
        {
            throw new NotImplementedException();
        }
    }

    public class ReadFullyStream : Stream
    {
        private Stream sourceStream;
        private long pos; // psuedo-position
        private byte[] readAheadBuffer;
        private int readAheadLength;
        private int readAheadOffset;

        public ReadFullyStream(Stream sourceStream)
        {
            this.sourceStream = sourceStream;
            this.readAheadBuffer = new byte[4096];
        }

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanSeek
        {
            get { return false; }
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void Flush()
        {
            throw new InvalidOperationException();
        }

        public override long Length
        {
            get { return pos; }
        }

        public override long Position
        {
            get { return pos; }
            set { throw new InvalidOperationException(); }
        }


        public override int Read(byte[] buffer, int offset, int count)
        {
            int bytesRead = 0;
            while (bytesRead < count)
            {
                int readAheadAvailableBytes = readAheadLength - readAheadOffset;
                int bytesRequired = count - bytesRead;
                if (readAheadAvailableBytes > 0)
                {
                    int toCopy = Math.Min(readAheadAvailableBytes, bytesRequired);
                    Array.Copy(readAheadBuffer, readAheadOffset, buffer, offset + bytesRead, toCopy);
                    bytesRead += toCopy;
                    readAheadOffset += toCopy;
                }
                else
                {
                    readAheadOffset = 0;
                    readAheadLength = sourceStream.Read(readAheadBuffer, 0, readAheadBuffer.Length);
                    //Debug.WriteLine(String.Format("Read {0} bytes (requested {1})", readAheadLength, readAheadBuffer.Length));
                    if (readAheadLength == 0)
                    {
                        break;
                    }
                }
            }
            this.pos += bytesRead;
            return bytesRead;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new InvalidOperationException();
        }

        public override void SetLength(long value)
        {
            throw new InvalidOperationException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new InvalidOperationException();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}