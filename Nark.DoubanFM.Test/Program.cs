using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Nark.DoubanFM.Model;
using Newtonsoft.Json;

namespace Nark.DoubanFM.Test
{
    class Program
    {
        private static Naudio_Player player = new Naudio_Player();

        private const string HelpMsg = "'number'   : play numbered music\n" +
                                        "'pause'    : pause or continue\n" +
                                        "'n'        : next\n" +
                                        "'p'        : previous\n" +
                                        "'u'or'd'   : volume up or down\n" +
                                        "'l'        : mark current as LIKE\n" +
                                        "'t'        : mark current as TRASH\n" +
                                        "'exit'     : exit the program\n" +
                                        "'h'        : help\n";

        private static int currentIndex = -1;
        private const string url = "http://douban.fm/j/mine/playlist";
        private static SongList_Douban pl;

        static void Main(string[] args)
        {
            //GetPlayList();

            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    Control(input);
            //}
            LoginIn();
        }

        private static void GetPlayList()
        {
            WebRequest webReq = WebRequest.Create(url);
            Stream retStream = webReq.GetResponse().GetResponseStream();
            string retStr;
            using (StreamReader sr = new StreamReader(retStream))
            {
                retStr = sr.ReadToEnd();
            }

            pl = JsonConvert.DeserializeObject<SongList_Douban>(retStr);
            for (int i = 0; i < pl.song.Length; i++)
            {
                Song_Douban song = pl.song[i];
                Console.WriteLine("{0}:{1}", i, song.Title);
            }
        }

        private static void Play(string input)
        {
            int index = currentIndex;
            if (int.TryParse(input, out index))
            {
                if (index >= 0 && index < pl.song.Length)
                {
                    player.Play(pl.song[index].Url);
                }
            }
        }

        static void PrintHelpMsg()
        {
            Console.WriteLine(HelpMsg);
        }

        static void Control(string input)
        {
            switch (input)
            {
                case "pause":
                    player.Pause();
                    break;
                case "n":
                    {
                        if (currentIndex + 1 > pl.song.Length - 1)
                        {
                            NextList();
                        }
                        else
                        {
                            currentIndex += 1;
                            player.Play(pl.song[currentIndex].Url);
                        }
                    }
                    break;
                case "p":
                    {
                        if (currentIndex - 1 < 0)
                        {
                            NextList();
                        }
                        else
                        {
                            currentIndex -= 1;
                            player.Play(pl.song[currentIndex].Url);
                        }
                    }
                    break;
                case "h":
                    PrintHelpMsg();
                    break;
                default:
                    Play(input);
                    break;
            }
        }

        private static void NextList()
        {
            currentIndex = 0;
            GetPlayList();
            Play("0");
        }

        static void LoginIn()
        {
            //http://douban.fm/j/new_captcha
            //http://douban.fm/misc/captcha?size=m&id=0iPlm837LsnSsJTMJrf5TZ7e
            //http://douban.fm/j/login?source=radio&alias=narcotics726@gmail.com&form_password=200436&captcha_solution=error&captcha_id=4g0lJCXureObIDENKDBO7seU&task=sync_channel_list
            string captchID;
            Bitmap imgCaptcha = GetCaptcha(out captchID);
            imgCaptcha.Save(AppDomain.CurrentDomain.BaseDirectory + @"/captcha.bmp");
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"/captcha.bmp");
            string strCaptcha = Console.ReadLine();
            string strUserName = Console.ReadLine();
            string strPwd = Console.ReadLine();

            string loginURL = string.Format("http://douban.fm/j/login?source=radio&alias={0}&form_password={1}&captcha_solution={2}&captcha_id={3}&task=sync_channel_list", strUserName, strPwd, strCaptcha, captchID);
            WebRequest webReq = WebRequest.Create(loginURL);
            Stream retStream = webReq.GetResponse().GetResponseStream();
            string retStr;
            using (StreamReader sr = new StreamReader(retStream))
            {
                retStr = sr.ReadToEnd();
            }
            Console.WriteLine(retStr);
        }

        private static Bitmap GetCaptcha(out string captchID)
        {
            captchID = "";
            WebRequest webReq = WebRequest.Create("http://douban.fm/j/new_captcha");
            Stream retStream = webReq.GetResponse().GetResponseStream();
            string retStr;
            using (StreamReader sr = new StreamReader(retStream))
            {
                retStr = sr.ReadToEnd();
            }
            captchID = retStr.Replace("\"", "");
            string captURL = "http://douban.fm/misc/captcha?size=m&id=" + captchID;
            webReq = WebRequest.Create(captURL);
            retStream = webReq.GetResponse().GetResponseStream();
            Bitmap retImg = (Bitmap)Bitmap.FromStream(retStream);
            return retImg;
        }
    }
}
