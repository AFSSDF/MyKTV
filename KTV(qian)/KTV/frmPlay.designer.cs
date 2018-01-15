namespace KTV
{
    partial class frmPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlay));
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblNextMvName = new System.Windows.Forms.Label();
            this.lblNowMvName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(315, 292);
            this.axWindowsMediaPlayer.TabIndex = 0;
            this.axWindowsMediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer_Enter);
            // 
            // lblNextMvName
            // 
            this.lblNextMvName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNextMvName.AutoSize = true;
            this.lblNextMvName.BackColor = System.Drawing.Color.Black;
            this.lblNextMvName.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNextMvName.ForeColor = System.Drawing.Color.White;
            this.lblNextMvName.Location = new System.Drawing.Point(115, 209);
            this.lblNextMvName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextMvName.Name = "lblNextMvName";
            this.lblNextMvName.Size = new System.Drawing.Size(73, 21);
            this.lblNextMvName.TabIndex = 2;
            this.lblNextMvName.Text = "无歌曲";
            // 
            // lblNowMvName
            // 
            this.lblNowMvName.AutoSize = true;
            this.lblNowMvName.BackColor = System.Drawing.Color.Black;
            this.lblNowMvName.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNowMvName.ForeColor = System.Drawing.Color.White;
            this.lblNowMvName.Location = new System.Drawing.Point(137, 18);
            this.lblNowMvName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNowMvName.Name = "lblNowMvName";
            this.lblNowMvName.Size = new System.Drawing.Size(73, 21);
            this.lblNowMvName.TabIndex = 1;
            this.lblNowMvName.Text = "无歌曲";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "正在播放：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "下一首：";
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNextMvName);
            this.Controls.Add(this.lblNowMvName);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Name = "frmPlay";
            this.Text = "播放";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNextMvName;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        public System.Windows.Forms.Label lblNowMvName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}