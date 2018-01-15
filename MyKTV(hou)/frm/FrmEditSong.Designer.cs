namespace MyKTV.frm
{
    partial class FrmEditSong
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
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblSongPinYin = new System.Windows.Forms.Label();
            this.lblSongTYpe = new System.Windows.Forms.Label();
            this.lblSongerName = new System.Windows.Forms.Label();
            this.lblSongFolderName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.txtSongPinYin = new System.Windows.Forms.TextBox();
            this.txtSongerName = new System.Windows.Forms.TextBox();
            this.txtSongFolderName = new System.Windows.Forms.TextBox();
            this.cboSongType = new System.Windows.Forms.ComboBox();
            this.ofdLookSong = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(59, 35);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(53, 12);
            this.lblSongName.TabIndex = 0;
            this.lblSongName.Text = "歌曲名称";
            // 
            // lblSongPinYin
            // 
            this.lblSongPinYin.AutoSize = true;
            this.lblSongPinYin.Location = new System.Drawing.Point(59, 79);
            this.lblSongPinYin.Name = "lblSongPinYin";
            this.lblSongPinYin.Size = new System.Drawing.Size(53, 12);
            this.lblSongPinYin.TabIndex = 1;
            this.lblSongPinYin.Text = "拼音缩写";
            // 
            // lblSongTYpe
            // 
            this.lblSongTYpe.AutoSize = true;
            this.lblSongTYpe.Location = new System.Drawing.Point(59, 115);
            this.lblSongTYpe.Name = "lblSongTYpe";
            this.lblSongTYpe.Size = new System.Drawing.Size(53, 12);
            this.lblSongTYpe.TabIndex = 2;
            this.lblSongTYpe.Text = "歌曲类型";
            // 
            // lblSongerName
            // 
            this.lblSongerName.AutoSize = true;
            this.lblSongerName.Location = new System.Drawing.Point(83, 158);
            this.lblSongerName.Name = "lblSongerName";
            this.lblSongerName.Size = new System.Drawing.Size(29, 12);
            this.lblSongerName.TabIndex = 3;
            this.lblSongerName.Text = "歌手";
            // 
            // lblSongFolderName
            // 
            this.lblSongFolderName.AutoSize = true;
            this.lblSongFolderName.Location = new System.Drawing.Point(35, 193);
            this.lblSongFolderName.Name = "lblSongFolderName";
            this.lblSongFolderName.Size = new System.Drawing.Size(77, 12);
            this.lblSongFolderName.TabIndex = 4;
            this.lblSongFolderName.Text = "歌曲文件夹名";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(321, 153);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(321, 219);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(75, 23);
            this.btnLook.TabIndex = 6;
            this.btnLook.Text = "浏览";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(227, 274);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(75, 23);
            this.btnMake.TabIndex = 7;
            this.btnMake.Text = "保存";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(321, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(118, 32);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(269, 21);
            this.txtSongName.TabIndex = 9;
            // 
            // txtSongPinYin
            // 
            this.txtSongPinYin.Location = new System.Drawing.Point(118, 76);
            this.txtSongPinYin.Name = "txtSongPinYin";
            this.txtSongPinYin.Size = new System.Drawing.Size(269, 21);
            this.txtSongPinYin.TabIndex = 10;
            // 
            // txtSongerName
            // 
            this.txtSongerName.Location = new System.Drawing.Point(118, 153);
            this.txtSongerName.Name = "txtSongerName";
            this.txtSongerName.Size = new System.Drawing.Size(184, 21);
            this.txtSongerName.TabIndex = 11;
            // 
            // txtSongFolderName
            // 
            this.txtSongFolderName.Location = new System.Drawing.Point(37, 221);
            this.txtSongFolderName.Name = "txtSongFolderName";
            this.txtSongFolderName.Size = new System.Drawing.Size(265, 21);
            this.txtSongFolderName.TabIndex = 12;
            // 
            // cboSongType
            // 
            this.cboSongType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSongType.FormattingEnabled = true;
            this.cboSongType.Location = new System.Drawing.Point(118, 112);
            this.cboSongType.Name = "cboSongType";
            this.cboSongType.Size = new System.Drawing.Size(269, 20);
            this.cboSongType.TabIndex = 13;
            // 
            // ofdLookSong
            // 
            this.ofdLookSong.FileName = "openFileDialog1";
            // 
            // FrmEditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 322);
            this.Controls.Add(this.cboSongType);
            this.Controls.Add(this.txtSongFolderName);
            this.Controls.Add(this.txtSongerName);
            this.Controls.Add(this.txtSongPinYin);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSongFolderName);
            this.Controls.Add(this.lblSongerName);
            this.Controls.Add(this.lblSongTYpe);
            this.Controls.Add(this.lblSongPinYin);
            this.Controls.Add(this.lblSongName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditSong";
            this.Text = "编辑歌曲信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblSongPinYin;
        private System.Windows.Forms.Label lblSongTYpe;
        private System.Windows.Forms.Label lblSongerName;
        private System.Windows.Forms.Label lblSongFolderName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.TextBox txtSongPinYin;
        private System.Windows.Forms.TextBox txtSongerName;
        private System.Windows.Forms.TextBox txtSongFolderName;
        private System.Windows.Forms.ComboBox cboSongType;
        private System.Windows.Forms.OpenFileDialog ofdLookSong;
    }
}