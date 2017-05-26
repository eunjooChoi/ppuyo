namespace 뿌요뿌요
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorAlone = new System.Windows.Forms.PictureBox();
            this.colorYou = new System.Windows.Forms.PictureBox();
            this.colorRanking = new System.Windows.Forms.PictureBox();
            this.colorEnd = new System.Windows.Forms.PictureBox();
            this.blackAlone = new System.Windows.Forms.PictureBox();
            this.blackYou = new System.Windows.Forms.PictureBox();
            this.blackRanking = new System.Windows.Forms.PictureBox();
            this.blackEnd = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorAlone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorYou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackAlone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackYou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorAlone
            // 
            this.colorAlone.BackColor = System.Drawing.Color.Transparent;
            this.colorAlone.Image = global::뿌요뿌요.Properties.Resources.나홀로;
            this.colorAlone.Location = new System.Drawing.Point(69, 238);
            this.colorAlone.Name = "colorAlone";
            this.colorAlone.Size = new System.Drawing.Size(532, 689);
            this.colorAlone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorAlone.TabIndex = 0;
            this.colorAlone.TabStop = false;
            // 
            // colorYou
            // 
            this.colorYou.BackColor = System.Drawing.Color.Transparent;
            this.colorYou.Image = global::뿌요뿌요.Properties.Resources.너랑나랑;
            this.colorYou.Location = new System.Drawing.Point(635, 183);
            this.colorYou.Name = "colorYou";
            this.colorYou.Size = new System.Drawing.Size(525, 748);
            this.colorYou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorYou.TabIndex = 1;
            this.colorYou.TabStop = false;
            this.colorYou.Visible = false;
            // 
            // colorRanking
            // 
            this.colorRanking.BackColor = System.Drawing.Color.Transparent;
            this.colorRanking.Image = global::뿌요뿌요.Properties.Resources.랭킹__2_;
            this.colorRanking.Location = new System.Drawing.Point(1199, 183);
            this.colorRanking.Name = "colorRanking";
            this.colorRanking.Size = new System.Drawing.Size(545, 759);
            this.colorRanking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorRanking.TabIndex = 2;
            this.colorRanking.TabStop = false;
            this.colorRanking.Visible = false;
            // 
            // colorEnd
            // 
            this.colorEnd.BackColor = System.Drawing.Color.Transparent;
            this.colorEnd.Image = global::뿌요뿌요.Properties.Resources.끝내기;
            this.colorEnd.Location = new System.Drawing.Point(1767, 224);
            this.colorEnd.Name = "colorEnd";
            this.colorEnd.Size = new System.Drawing.Size(525, 718);
            this.colorEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorEnd.TabIndex = 3;
            this.colorEnd.TabStop = false;
            this.colorEnd.Visible = false;
            // 
            // blackAlone
            // 
            this.blackAlone.BackColor = System.Drawing.Color.Transparent;
            this.blackAlone.Image = global::뿌요뿌요.Properties.Resources.흑백나홀로;
            this.blackAlone.Location = new System.Drawing.Point(69, 337);
            this.blackAlone.Name = "blackAlone";
            this.blackAlone.Size = new System.Drawing.Size(525, 715);
            this.blackAlone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackAlone.TabIndex = 4;
            this.blackAlone.TabStop = false;
            this.blackAlone.Visible = false;
            // 
            // blackYou
            // 
            this.blackYou.BackColor = System.Drawing.Color.Transparent;
            this.blackYou.Image = global::뿌요뿌요.Properties.Resources.흑백너랑나랑;
            this.blackYou.Location = new System.Drawing.Point(635, 337);
            this.blackYou.Name = "blackYou";
            this.blackYou.Size = new System.Drawing.Size(525, 728);
            this.blackYou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackYou.TabIndex = 5;
            this.blackYou.TabStop = false;
            // 
            // blackRanking
            // 
            this.blackRanking.BackColor = System.Drawing.Color.Transparent;
            this.blackRanking.Image = global::뿌요뿌요.Properties.Resources.흑백랭킹;
            this.blackRanking.Location = new System.Drawing.Point(1219, 314);
            this.blackRanking.Name = "blackRanking";
            this.blackRanking.Size = new System.Drawing.Size(525, 738);
            this.blackRanking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackRanking.TabIndex = 6;
            this.blackRanking.TabStop = false;
            // 
            // blackEnd
            // 
            this.blackEnd.BackColor = System.Drawing.Color.Transparent;
            this.blackEnd.Image = global::뿌요뿌요.Properties.Resources.흑백끝내기;
            this.blackEnd.Location = new System.Drawing.Point(1754, 247);
            this.blackEnd.Name = "blackEnd";
            this.blackEnd.Size = new System.Drawing.Size(566, 805);
            this.blackEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackEnd.TabIndex = 7;
            this.blackEnd.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(295, 81);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::뿌요뿌요.Properties.Resources.투명모드선택;
            this.pictureBox1.Location = new System.Drawing.Point(552, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1274, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::뿌요뿌요.Properties.Resources.배경11;
            this.ClientSize = new System.Drawing.Size(2353, 1105);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.colorRanking);
            this.Controls.Add(this.colorYou);
            this.Controls.Add(this.colorAlone);
            this.Controls.Add(this.blackRanking);
            this.Controls.Add(this.blackYou);
            this.Controls.Add(this.colorEnd);
            this.Controls.Add(this.blackEnd);
            this.Controls.Add(this.blackAlone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.colorAlone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorYou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackAlone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackYou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox colorAlone;
        private System.Windows.Forms.PictureBox colorYou;
        private System.Windows.Forms.PictureBox colorRanking;
        private System.Windows.Forms.PictureBox colorEnd;
        private System.Windows.Forms.PictureBox blackAlone;
        private System.Windows.Forms.PictureBox blackYou;
        private System.Windows.Forms.PictureBox blackRanking;
        private System.Windows.Forms.PictureBox blackEnd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

