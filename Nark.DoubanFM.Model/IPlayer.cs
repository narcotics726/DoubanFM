using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nark.DoubanFM.Model
{
    internal interface IPlayer
    {
        void Play(string url);
        void Play(Stream stream);
        void Pause();
        void Continue();
        void Next();
        void Previous();
    }
}