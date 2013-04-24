namespace Nark.DoubanFM.WinForm
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_Player = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.slider_Volumn = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.img_Song = new System.Windows.Forms.PictureBox();
            this.tb_Right = new System.Windows.Forms.TableLayoutPanel();
            this.tb_RightBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Like = new System.Windows.Forms.Button();
            this.btn_Trash = new System.Windows.Forms.Button();
            this.tb_RightTop = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Progress = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Progress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_Config = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Captcha = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.img_Captcha = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_GetCaptcha = new System.Windows.Forms.Button();
            this.tab_Channel = new System.Windows.Forms.TabPage();
            this.tab.SuspendLayout();
            this.tab_Player.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Volumn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Song)).BeginInit();
            this.tb_Right.SuspendLayout();
            this.tb_RightBottom.SuspendLayout();
            this.tb_RightTop.SuspendLayout();
            this.tb_Progress.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tab_Config.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab_Player);
            this.tab.Controls.Add(this.tab_Config);
            this.tab.Controls.Add(this.tab_Channel);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(544, 276);
            this.tab.TabIndex = 0;
            // 
            // tab_Player
            // 
            this.tab_Player.Controls.Add(this.tableLayoutPanel1);
            this.tab_Player.Location = new System.Drawing.Point(4, 22);
            this.tab_Player.Name = "tab_Player";
            this.tab_Player.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Player.Size = new System.Drawing.Size(536, 250);
            this.tab_Player.TabIndex = 0;
            this.tab_Player.Text = "Player";
            this.tab_Player.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.slider_Volumn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Right, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 244);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // slider_Volumn
            // 
            this.slider_Volumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slider_Volumn.Location = new System.Drawing.Point(3, 217);
            this.slider_Volumn.Maximum = 100;
            this.slider_Volumn.Name = "slider_Volumn";
            this.slider_Volumn.Size = new System.Drawing.Size(238, 24);
            this.slider_Volumn.TabIndex = 1;
            this.slider_Volumn.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.img_Song);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 208);
            this.panel2.TabIndex = 2;
            // 
            // img_Song
            // 
            this.img_Song.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_Song.Location = new System.Drawing.Point(0, 0);
            this.img_Song.Name = "img_Song";
            this.img_Song.Size = new System.Drawing.Size(238, 208);
            this.img_Song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_Song.TabIndex = 3;
            this.img_Song.TabStop = false;
            // 
            // tb_Right
            // 
            this.tb_Right.ColumnCount = 1;
            this.tb_Right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_Right.Controls.Add(this.tb_RightBottom, 0, 1);
            this.tb_Right.Controls.Add(this.tb_RightTop, 0, 0);
            this.tb_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Right.Location = new System.Drawing.Point(247, 3);
            this.tb_Right.Name = "tb_Right";
            this.tb_Right.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tb_Right, 2);
            this.tb_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.94958F));
            this.tb_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.05042F));
            this.tb_Right.Size = new System.Drawing.Size(280, 238);
            this.tb_Right.TabIndex = 3;
            // 
            // tb_RightBottom
            // 
            this.tb_RightBottom.ColumnCount = 3;
            this.tb_RightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tb_RightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tb_RightBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tb_RightBottom.Controls.Add(this.btn_Like, 0, 0);
            this.tb_RightBottom.Controls.Add(this.btn_Trash, 2, 0);
            this.tb_RightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_RightBottom.Location = new System.Drawing.Point(0, 175);
            this.tb_RightBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tb_RightBottom.Name = "tb_RightBottom";
            this.tb_RightBottom.RowCount = 1;
            this.tb_RightBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_RightBottom.Size = new System.Drawing.Size(280, 63);
            this.tb_RightBottom.TabIndex = 0;
            // 
            // btn_Like
            // 
            this.btn_Like.BackColor = System.Drawing.Color.Transparent;
            this.btn_Like.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Like.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Like.FlatAppearance.BorderSize = 0;
            this.btn_Like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Like.Location = new System.Drawing.Point(33, 3);
            this.btn_Like.Name = "btn_Like";
            this.btn_Like.Size = new System.Drawing.Size(57, 57);
            this.btn_Like.TabIndex = 0;
            this.btn_Like.UseVisualStyleBackColor = false;
            // 
            // btn_Trash
            // 
            this.btn_Trash.BackColor = System.Drawing.Color.Transparent;
            this.btn_Trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Trash.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Trash.FlatAppearance.BorderSize = 0;
            this.btn_Trash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Trash.Location = new System.Drawing.Point(189, 3);
            this.btn_Trash.Name = "btn_Trash";
            this.btn_Trash.Size = new System.Drawing.Size(57, 57);
            this.btn_Trash.TabIndex = 1;
            this.btn_Trash.UseVisualStyleBackColor = false;
            // 
            // tb_RightTop
            // 
            this.tb_RightTop.ColumnCount = 1;
            this.tb_RightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_RightTop.Controls.Add(this.tb_Progress, 0, 1);
            this.tb_RightTop.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tb_RightTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_RightTop.Location = new System.Drawing.Point(0, 0);
            this.tb_RightTop.Margin = new System.Windows.Forms.Padding(0);
            this.tb_RightTop.Name = "tb_RightTop";
            this.tb_RightTop.RowCount = 2;
            this.tb_RightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_RightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tb_RightTop.Size = new System.Drawing.Size(280, 175);
            this.tb_RightTop.TabIndex = 1;
            // 
            // tb_Progress
            // 
            this.tb_Progress.ColumnCount = 1;
            this.tb_Progress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_Progress.Controls.Add(this.lb_Progress, 0, 1);
            this.tb_Progress.Controls.Add(this.progressBar1, 0, 0);
            this.tb_Progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Progress.Location = new System.Drawing.Point(0, 135);
            this.tb_Progress.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Progress.Name = "tb_Progress";
            this.tb_Progress.RowCount = 2;
            this.tb_Progress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_Progress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_Progress.Size = new System.Drawing.Size(280, 40);
            this.tb_Progress.TabIndex = 0;
            // 
            // lb_Progress
            // 
            this.lb_Progress.AutoSize = true;
            this.lb_Progress.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_Progress.Location = new System.Drawing.Point(206, 20);
            this.lb_Progress.Name = "lb_Progress";
            this.lb_Progress.Size = new System.Drawing.Size(71, 20);
            this.lb_Progress.TabIndex = 0;
            this.lb_Progress.Text = "02:33/05:12";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(274, 14);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 34;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.34783F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.65217F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 129);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Love";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Relapse";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eminem";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_Config
            // 
            this.tab_Config.Controls.Add(this.tableLayoutPanel3);
            this.tab_Config.Location = new System.Drawing.Point(4, 22);
            this.tab_Config.Name = "tab_Config";
            this.tab_Config.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Config.Size = new System.Drawing.Size(536, 250);
            this.tab_Config.TabIndex = 1;
            this.tab_Config.Text = "Config";
            this.tab_Config.UseVisualStyleBackColor = true;
            this.tab_Config.Enter += new System.EventHandler(this.tab_Config_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.65574F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.34426F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(530, 244);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.txt_Name, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_Captcha, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_Pwd, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.img_Captcha, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_Login, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_GetCaptcha, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 151);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(524, 90);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txt_Name
            // 
            this.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Name.Location = new System.Drawing.Point(3, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(168, 21);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.Text = "Input User Name Here";
            // 
            // txt_Captcha
            // 
            this.txt_Captcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Captcha.Location = new System.Drawing.Point(3, 48);
            this.txt_Captcha.Name = "txt_Captcha";
            this.txt_Captcha.Size = new System.Drawing.Size(168, 21);
            this.txt_Captcha.TabIndex = 1;
            this.txt_Captcha.Text = "Wait For Loading the Captcha";
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Pwd.Location = new System.Drawing.Point(177, 3);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(168, 21);
            this.txt_Pwd.TabIndex = 2;
            this.txt_Pwd.Text = "Input Password Here";
            // 
            // img_Captcha
            // 
            this.img_Captcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_Captcha.Location = new System.Drawing.Point(177, 48);
            this.img_Captcha.Name = "img_Captcha";
            this.img_Captcha.Size = new System.Drawing.Size(168, 39);
            this.img_Captcha.TabIndex = 3;
            this.img_Captcha.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(351, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_GetCaptcha
            // 
            this.btn_GetCaptcha.Location = new System.Drawing.Point(351, 48);
            this.btn_GetCaptcha.Name = "btn_GetCaptcha";
            this.btn_GetCaptcha.Size = new System.Drawing.Size(75, 23);
            this.btn_GetCaptcha.TabIndex = 5;
            this.btn_GetCaptcha.Text = "Refresh";
            this.btn_GetCaptcha.UseVisualStyleBackColor = true;
            this.btn_GetCaptcha.Click += new System.EventHandler(this.btn_GetCaptcha_Click);
            // 
            // tab_Channel
            // 
            this.tab_Channel.Location = new System.Drawing.Point(4, 22);
            this.tab_Channel.Name = "tab_Channel";
            this.tab_Channel.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Channel.Size = new System.Drawing.Size(536, 250);
            this.tab_Channel.TabIndex = 2;
            this.tab_Channel.Text = "Channel";
            this.tab_Channel.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 276);
            this.Controls.Add(this.tab);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nark.DoubanFM";
            this.tab.ResumeLayout(false);
            this.tab_Player.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Volumn)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Song)).EndInit();
            this.tb_Right.ResumeLayout(false);
            this.tb_RightBottom.ResumeLayout(false);
            this.tb_RightTop.ResumeLayout(false);
            this.tb_Progress.ResumeLayout(false);
            this.tb_Progress.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tab_Config.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Captcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab_Player;
        private System.Windows.Forms.TabPage tab_Config;
        private System.Windows.Forms.TabPage tab_Channel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar slider_Volumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox img_Song;
        private System.Windows.Forms.TableLayoutPanel tb_Right;
        private System.Windows.Forms.TableLayoutPanel tb_RightBottom;
        private System.Windows.Forms.Button btn_Trash;
        private System.Windows.Forms.Button btn_Like;
        private System.Windows.Forms.TableLayoutPanel tb_RightTop;
        private System.Windows.Forms.TableLayoutPanel tb_Progress;
        private System.Windows.Forms.Label lb_Progress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Captcha;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.PictureBox img_Captcha;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_GetCaptcha;
    }
}

