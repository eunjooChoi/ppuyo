namespace 뿌요뿌요
{
    partial class _1Por2P
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
            this.player1 = new System.Windows.Forms.Button();
            this.player2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(92, 221);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(356, 291);
            this.player1.TabIndex = 0;
            this.player1.Text = "PLAYER1";
            this.player1.UseVisualStyleBackColor = true;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(521, 221);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(356, 291);
            this.player2.TabIndex = 1;
            this.player2.Text = "PLAYER2";
            this.player2.UseVisualStyleBackColor = true;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // _1Por2P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 818);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Name = "_1Por2P";
            this.Text = "_1Por2P";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button player1;
        private System.Windows.Forms.Button player2;
    }
}