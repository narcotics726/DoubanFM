using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nark.DoubanFM.Model
{
    public abstract class Song
    {
        #region Field

        private string url;
        private string title;

        #endregion

        #region Property

        /// <summary>
        /// 曲目名
        /// </summary>
        public virtual string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// 歌曲URL
        /// </summary>
        public virtual string Url
        {
            get { return url; }
            set { url = value; }
        }

        #endregion
    }
}