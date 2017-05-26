namespace 뿌요뿌요
{
    partial class Alone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alone));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nextPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLable = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(74, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 1147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::뿌요뿌요.Properties.Resources.KakaoTalk_20160616_171044598;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(895, 1235);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(439, 192);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1072, 1065);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(211, 156);
            this.textBox1.TabIndex = 2;
            // 
            // nextPictureBox
            // 
            this.nextPictureBox.Location = new System.Drawing.Point(831, 221);
            this.nextPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextPictureBox.Name = "nextPictureBox";
            this.nextPictureBox.Size = new System.Drawing.Size(516, 284);
            this.nextPictureBox.TabIndex = 3;
            this.nextPictureBox.TabStop = false;
            this.nextPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.nextPictureBox_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox2.Location = new System.Drawing.Point(74, 1247);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 53);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreLable
            // 
            this.scoreLable.AutoSize = true;
            this.scoreLable.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.scoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scoreLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLable.Location = new System.Drawing.Point(972, 1094);
            this.scoreLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLable.Name = "scoreLable";
            this.scoreLable.Size = new System.Drawing.Size(52, 55);
            this.scoreLable.TabIndex = 5;
            this.scoreLable.Text = "0";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1897, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_1);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "BackGround.gif");
            this.imageList.Images.SetKeyName(1, "Wall.jpg");
            this.imageList.Images.SetKeyName(2, "Yellow.gif");
            this.imageList.Images.SetKeyName(3, "Blue.gif");
            this.imageList.Images.SetKeyName(4, "Green.gif");
            this.imageList.Images.SetKeyName(5, "Purple.gif");
            this.imageList.Images.SetKeyName(6, "Red.gif");
            this.imageList.Images.SetKeyName(7, "Yellow2.gif");
            this.imageList.Images.SetKeyName(8, "Yellow3.gif");
            this.imageList.Images.SetKeyName(9, "Yellow4.gif");
            this.imageList.Images.SetKeyName(10, "Yellow5.png");
            this.imageList.Images.SetKeyName(11, "Yellow6.png");
            this.imageList.Images.SetKeyName(12, "Yellow7.png");
            this.imageList.Images.SetKeyName(13, "Yellow8.png");
            this.imageList.Images.SetKeyName(14, "Yellow9.png");
            this.imageList.Images.SetKeyName(15, "Yellow10.png");
            this.imageList.Images.SetKeyName(16, "Yellow11.png");
            this.imageList.Images.SetKeyName(17, "Yellow12.png");
            this.imageList.Images.SetKeyName(18, "Yellow13.png");
            this.imageList.Images.SetKeyName(19, "Yellow14.png");
            this.imageList.Images.SetKeyName(20, "Yellow15.png");
            this.imageList.Images.SetKeyName(21, "Yellow16.png");
            this.imageList.Images.SetKeyName(22, "Yellow17.png");
            this.imageList.Images.SetKeyName(23, "Blue2.gif");
            this.imageList.Images.SetKeyName(24, "Blue3.gif");
            this.imageList.Images.SetKeyName(25, "Blue4.gif");
            this.imageList.Images.SetKeyName(26, "Blue5.png");
            this.imageList.Images.SetKeyName(27, "Blue6.png");
            this.imageList.Images.SetKeyName(28, "Blue7.png");
            this.imageList.Images.SetKeyName(29, "Blue9.png");
            this.imageList.Images.SetKeyName(30, "Blue8.png");
            this.imageList.Images.SetKeyName(31, "Blue10.png");
            this.imageList.Images.SetKeyName(32, "Blue11.png");
            this.imageList.Images.SetKeyName(33, "Blue12.png");
            this.imageList.Images.SetKeyName(34, "Blue13.png");
            this.imageList.Images.SetKeyName(35, "Blue14.png");
            this.imageList.Images.SetKeyName(36, "Blue15.png");
            this.imageList.Images.SetKeyName(37, "Blue16.png");
            this.imageList.Images.SetKeyName(38, "Blue17.png");
            this.imageList.Images.SetKeyName(39, "Green2.gif");
            this.imageList.Images.SetKeyName(40, "Green3.gif");
            this.imageList.Images.SetKeyName(41, "Green4.gif");
            this.imageList.Images.SetKeyName(42, "Green5.png");
            this.imageList.Images.SetKeyName(43, "Green6.png");
            this.imageList.Images.SetKeyName(44, "Green7.png");
            this.imageList.Images.SetKeyName(45, "Green8.png");
            this.imageList.Images.SetKeyName(46, "Green9.png");
            this.imageList.Images.SetKeyName(47, "Green10.png");
            this.imageList.Images.SetKeyName(48, "Green11.png");
            this.imageList.Images.SetKeyName(49, "Green12.png");
            this.imageList.Images.SetKeyName(50, "Green13.png");
            this.imageList.Images.SetKeyName(51, "Green14.png");
            this.imageList.Images.SetKeyName(52, "Green15.png");
            this.imageList.Images.SetKeyName(53, "Green16.png");
            this.imageList.Images.SetKeyName(54, "Green17.png");
            this.imageList.Images.SetKeyName(55, "Purple2.gif");
            this.imageList.Images.SetKeyName(56, "Purple3.gif");
            this.imageList.Images.SetKeyName(57, "Purple4.gif");
            this.imageList.Images.SetKeyName(58, "Purple5.png");
            this.imageList.Images.SetKeyName(59, "Purple6.png");
            this.imageList.Images.SetKeyName(60, "Purple7.png");
            this.imageList.Images.SetKeyName(61, "Purple8.png");
            this.imageList.Images.SetKeyName(62, "Purple9.png");
            this.imageList.Images.SetKeyName(63, "Purple10.png");
            this.imageList.Images.SetKeyName(64, "Purple11.png");
            this.imageList.Images.SetKeyName(65, "Purple12.png");
            this.imageList.Images.SetKeyName(66, "Purple13.png");
            this.imageList.Images.SetKeyName(67, "Purple14.png");
            this.imageList.Images.SetKeyName(68, "Purple15.png");
            this.imageList.Images.SetKeyName(69, "Purple16.png");
            this.imageList.Images.SetKeyName(70, "Purple17.png");
            this.imageList.Images.SetKeyName(71, "Red2.gif");
            this.imageList.Images.SetKeyName(72, "Red3.gif");
            this.imageList.Images.SetKeyName(73, "Red4.gif");
            this.imageList.Images.SetKeyName(74, "Red5.png");
            this.imageList.Images.SetKeyName(75, "Red6.png");
            this.imageList.Images.SetKeyName(76, "Red7.png");
            this.imageList.Images.SetKeyName(77, "Red8.png");
            this.imageList.Images.SetKeyName(78, "Red9.png");
            this.imageList.Images.SetKeyName(79, "Red10.png");
            this.imageList.Images.SetKeyName(80, "Red11.png");
            this.imageList.Images.SetKeyName(81, "Red12.png");
            this.imageList.Images.SetKeyName(82, "Red13.png");
            this.imageList.Images.SetKeyName(83, "Red14.png");
            this.imageList.Images.SetKeyName(84, "Red15.png");
            this.imageList.Images.SetKeyName(85, "Red16.png");
            this.imageList.Images.SetKeyName(86, "Red17.png");
            this.imageList.Images.SetKeyName(87, "Yellow18.png");
            this.imageList.Images.SetKeyName(88, "Yellow19.png");
            this.imageList.Images.SetKeyName(89, "Yellow20.png");
            this.imageList.Images.SetKeyName(90, "Blue18.png");
            this.imageList.Images.SetKeyName(91, "Blue19.png");
            this.imageList.Images.SetKeyName(92, "Blue20.png");
            this.imageList.Images.SetKeyName(93, "Green18.png");
            this.imageList.Images.SetKeyName(94, "Green19.png");
            this.imageList.Images.SetKeyName(95, "Green20.png");
            this.imageList.Images.SetKeyName(96, "Purple18.png");
            this.imageList.Images.SetKeyName(97, "Purple19.png");
            this.imageList.Images.SetKeyName(98, "Purple20.png");
            this.imageList.Images.SetKeyName(99, "Red18.png");
            this.imageList.Images.SetKeyName(100, "Red19.png");
            this.imageList.Images.SetKeyName(101, "Red20.png");
            this.imageList.Images.SetKeyName(102, "Hudle.gif");
            this.imageList.Images.SetKeyName(103, "Hudle2.gif");
            this.imageList.Images.SetKeyName(104, "Hudle3.gif");
            this.imageList.Images.SetKeyName(105, "Hudle4.jpg");
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(1258, 13);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(139, 108);
            this.axWindowsMediaPlayer2.TabIndex = 8;
            this.axWindowsMediaPlayer2.Visible = false;
            this.axWindowsMediaPlayer2.Enter += new System.EventHandler(this.axWindowsMediaPlayer2_Enter);
            // 
            // Alone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::뿌요뿌요.Properties.Resources._1p;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1409, 1397);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.scoreLable);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nextPictureBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Alone";
            this.Text = "Alone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alone_FormClosing);
            this.Load += new System.EventHandler(this.Alone_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Alone_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox nextPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLable;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ImageList imageList;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
    }
}