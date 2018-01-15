namespace MyKTV.frm
{
    partial class frmAddSonger
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoZu = new System.Windows.Forms.RadioButton();
            this.rdoGilr = new System.Windows.Forms.RadioButton();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.cboLei = new System.Windows.Forms.ComboBox();
            this.txtMiao = new System.Windows.Forms.TextBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ofdLooksonger = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "歌手类别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "歌手描述";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(105, 51);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(165, 21);
            this.txtname.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoZu);
            this.panel1.Controls.Add(this.rdoGilr);
            this.panel1.Controls.Add(this.rdoMan);
            this.panel1.Location = new System.Drawing.Point(105, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 33);
            this.panel1.TabIndex = 2;
            // 
            // rdoZu
            // 
            this.rdoZu.AutoSize = true;
            this.rdoZu.Location = new System.Drawing.Point(118, 8);
            this.rdoZu.Name = "rdoZu";
            this.rdoZu.Size = new System.Drawing.Size(47, 16);
            this.rdoZu.TabIndex = 0;
            this.rdoZu.TabStop = true;
            this.rdoZu.Text = "组合";
            this.rdoZu.UseVisualStyleBackColor = true;
            // 
            // rdoGilr
            // 
            this.rdoGilr.AutoSize = true;
            this.rdoGilr.Location = new System.Drawing.Point(68, 8);
            this.rdoGilr.Name = "rdoGilr";
            this.rdoGilr.Size = new System.Drawing.Size(35, 16);
            this.rdoGilr.TabIndex = 0;
            this.rdoGilr.TabStop = true;
            this.rdoGilr.Text = "女";
            this.rdoGilr.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Location = new System.Drawing.Point(3, 8);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(35, 16);
            this.rdoMan.TabIndex = 0;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // cboLei
            // 
            this.cboLei.FormattingEnabled = true;
            this.cboLei.Location = new System.Drawing.Point(105, 221);
            this.cboLei.Name = "cboLei";
            this.cboLei.Size = new System.Drawing.Size(197, 20);
            this.cboLei.TabIndex = 3;
            // 
            // txtMiao
            // 
            this.txtMiao.Location = new System.Drawing.Point(91, 279);
            this.txtMiao.Multiline = true;
            this.txtMiao.Name = "txtMiao";
            this.txtMiao.Size = new System.Drawing.Size(342, 128);
            this.txtMiao.TabIndex = 4;
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(337, 51);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(144, 139);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 5;
            this.picPhoto.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "添加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ofdLooksonger
            // 
            this.ofdLooksonger.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddSonger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.txtMiao);
            this.Controls.Add(this.cboLei);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddSonger";
            this.Text = "编辑歌手信息";
            this.Load += new System.EventHandler(this.frmAddSonger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoZu;
        private System.Windows.Forms.RadioButton rdoGilr;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.ComboBox cboLei;
        private System.Windows.Forms.TextBox txtMiao;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog ofdLooksonger;
        private System.Windows.Forms.Button button1;
    }
}