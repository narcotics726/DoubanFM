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
using Newtonsoft.Json;

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
            ShowCaptchaAsync();
        }

        private void ShowCaptchaAsync()
        {
            Thread t = new Thread(new ThreadStart(LoadCaptcha));
            t.IsBackground = true;
            t.Start();
        }

        private void LoadCaptcha()
        {
            btn_GetCaptcha.Enabled = false;
            btn_Login.Enabled = false;
            string captchID;
            Bitmap imgCaptcha = GetCaptcha(out captchID);
            imgCaptcha = new Bitmap(imgCaptcha, img_Captcha.Size);
            img_Captcha.Image = imgCaptcha;
            img_Captcha.Tag = captchID;
            btn_GetCaptcha.Enabled = true;
            btn_Login.Enabled = true;
        }

        private Bitmap GetCaptcha(out string captchID)
        {
            Stream retStream = Helper.GetStreamFromURL("http://douban.fm/j/new_captcha");
            string retStr;
            using (StreamReader sr = new StreamReader(retStream))
            {
                retStr = sr.ReadToEnd();
            }
            captchID = retStr.Replace("\"", "");
            string captURL = "http://douban.fm/misc/captcha?size=m&id=" + captchID;
            retStream = Helper.GetStreamFromURL(captURL);
            Bitmap retImg = (Bitmap)Image.FromStream(retStream);
            return retImg;
        }

        private void btn_GetCaptcha_Click(object sender, EventArgs e)
        {
            ShowCaptchaAsync();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            List<TextBox> inputList = new List<TextBox>() { txt_Name, txt_Pwd, txt_Captcha };
            if (ValidateInputCollection(inputList))
            {
                LoginIn(txt_Name.Text, txt_Pwd.Text, txt_Captcha.Text);
            }
        }

        private void LoginIn(string strUserName, string strPwd, string strCaptcha)
        {
            string captchaID = img_Captcha.Tag.ToString();
            string loginURL = string.Format("http://douban.fm/j/login?source=radio&alias={0}&form_password={1}&captcha_solution={2}&captcha_id={3}&task=sync_channel_list", strUserName, strPwd, strCaptcha, captchaID);
            LoginReturnInfo_Douban loginReturnInfo = Helper.GetObjectFromURL<LoginReturnInfo_Douban>(loginURL);
            if (!string.IsNullOrWhiteSpace(loginReturnInfo.err_msg))
            {
                MessageBox.Show(loginReturnInfo.err_msg);
                ShowCaptchaAsync();
            }
            else
            {
                this.Text = string.Format("{0}'s Douban FM", loginReturnInfo.user_info.name);
            }
        }

        private bool ValidateInputCollection(List<TextBox> inputList)
        {
            bool isAllValid = inputList.Aggregate(true, (current, input) => current && ValidateInput(input));
            return isAllValid;
        }

        private bool ValidateInput(TextBox input)
        {
            bool isValid = (!string.IsNullOrWhiteSpace(input.Text));
            input.BackColor = !isValid ? Color.Red : SystemColors.Window;
            return isValid;
        }
    }
}
