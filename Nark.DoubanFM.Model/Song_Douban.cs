using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nark.DoubanFM.Model
{
    public class Song_Douban : Song
    {
        #region Field

        private string album;
        private string picture;
        private string ssid;
        private string artist;
        private string url;
        private string company;
        private string title;
        private float rating_avg;
        private int length;
        private string subtype;
        private string public_time;
        private string sid;
        private string aid;
        private string kbps;
        private string albumtitle;
        private bool like;

        #endregion

        #region Property

        /// <summary>
        /// 曲目名
        /// </summary>
        public override string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// 艺术家
        /// </summary>
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        /// <summary>
        /// 专辑名称
        /// </summary>
        public string Album
        {
            get { return album; }
            set { album = value; }
        }

        /// <summary>
        /// 歌曲URL
        /// </summary>
        public override string Url
        {
            get { return url; }
            set { url = value; }
        }

        /// <summary>
        /// 图片URL
        /// </summary>
        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        /// <summary>
        /// 喜欢
        /// </summary>
        public bool Like
        {
            get { return like; }
            set { like = value; }
        }

        #endregion

    }
}
