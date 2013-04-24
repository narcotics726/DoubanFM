using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nark.DoubanFM.Model
{
    public class Helper
    {
        public static Stream GetStreamFromURL(string url)
        {
            WebRequest webReq = WebRequest.Create(url);
            Stream retStream = webReq.GetResponse().GetResponseStream();
            return retStream;
        }

        public static string GetStringFromURL(string url)
        {
            Stream stream = GetStreamFromURL(url);
            string retStr;
            using (StreamReader sr = new StreamReader(stream))
            {
                retStr = sr.ReadToEnd();
            }
            return retStr;
        }

        public static T GetObjectFromURL<T>(string url)
        {
            string retStr = GetStringFromURL(url);
            T obj = JsonConvert.DeserializeObject<T>(retStr);
            return obj;
        }
    }
}
