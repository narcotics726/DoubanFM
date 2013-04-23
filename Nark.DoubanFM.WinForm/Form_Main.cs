using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nark.DoubanFM.Model;

namespace Nark.DoubanFM.WinForm
{
    public partial class Form_Main : Form
    {
        private ToolTip toolTip_Volumn = new ToolTip();
        private SongList_Douban currentList = new SongList_Douban();

        public Form_Main()
        {
            InitializeComponent();
            img_Song.Image = new Bitmap(@"C:\Users\Nark\Pictures\h_large_B2sP_7a93000093b12f75.jpg");
            InitEventReg();

        }

        private void InitEventReg()
        {
            btn_Like.MouseEnter += btn_Like_MouseEnter;
            btn_Like.MouseLeave += btn_Like_MouseLeave;

            slider_Volumn.ValueChanged += slider_Volumn_ValueChanged;
        }

        void slider_Volumn_ValueChanged(object sender, EventArgs e)
        {
            toolTip_Volumn = new ToolTip();
            toolTip_Volumn.AutoPopDelay = 5000;
            toolTip_Volumn.InitialDelay = 0;
            toolTip_Volumn.ReshowDelay = 0;
            toolTip_Volumn.ShowAlways = true;
            toolTip_Volumn.SetToolTip(slider_Volumn, slider_Volumn.Value.ToString());
        }

        void btn_Like_MouseLeave(object sender, EventArgs e)
        {
            Image img = new Bitmap(Properties.Resources.Like_0, btn_Like.Size);
            btn_Like.Image = img;
        }

        void btn_Like_MouseEnter(object sender, EventArgs e)
        {
            Image img = new Bitmap(Properties.Resources.Like_1, btn_Like.Size);
            btn_Like.Image = img;
        }

        private void tab_Config_Enter(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(LoadCaptcha));
            t.IsBackground = true;
            t.Start();
        }

        private void LoadCaptcha()
        {
            string captchID;
            Bitmap imgCaptcha = GetCaptcha(out captchID);
            imgCaptcha = new Bitmap(imgCaptcha, img_Captcha.Size);
            img_Captcha.Image = imgCaptcha;
        }

        private Bitmap GetCaptcha(out string captchID)
        {
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
