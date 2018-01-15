namespace MyKTV.frm
{
    partial class FrmSearchSong
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
            this.lblSongName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSongType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.dgvSongList = new System.Windows.Forms.DataGridView();
            this.ctmsSongMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(39, 22);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(41, 12);
            this.lblSongName.TabIndex = 0;
            this.lblSongName.Text = "歌曲名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblSongType
            // 
            this.lblSongType.AutoSize = true;
            this.lblSongType.Location = new System.Drawing.Point(279, 22);
            this.lblSongType.Name = "lblSongType";
            this.lblSongType.Size = new System.Drawing.Size(53, 12);
            this.lblSongType.TabIndex = 2;
            this.lblSongType.Text = "歌曲类型";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(336, 20);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(159, 20);
            this.cboType.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(530, 18);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "查询";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvSongList
            // 
            this.dgvSongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongList.Location = new System.Drawing.Point(12, 47);
            this.dgvSongList.Name = "dgvSongList";
            this.dgvSongList.RowTemplate.Height = 23;
            this.dgvSongList.Size = new System.Drawing.Size(630, 273);
            this.dgvSongList.TabIndex = 5;
            // 
            // ctmsSongMenu
            // 
            this.ctmsSongMenu.Name = "ctmsSongMenu";
            this.ctmsSongMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmSearchSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 332);
            this.Controls.Add(this.dgvSongList);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblSongType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSongName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSearchSong";
            this.Text = "歌曲查询";
            this.Load += new System.EventHandler(this.FrmAddSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSongType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView dgvSongList;
        private System.Windows.Forms.ContextMenuStrip ctmsSongMenu;
    }
}