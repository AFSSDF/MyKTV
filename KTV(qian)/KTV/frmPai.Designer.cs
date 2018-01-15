namespace KTV
{
    partial class frmPai
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
            this.dgvpai = new System.Windows.Forms.DataGridView();
            this.sing_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songer_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpai)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpai
            // 
            this.dgvpai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvpai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpai.BackgroundColor = System.Drawing.Color.White;
            this.dgvpai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sing_name,
            this.path,
            this.songer_name,
            this.songer_path});
            this.dgvpai.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvpai.Location = new System.Drawing.Point(1, 58);
            this.dgvpai.MultiSelect = false;
            this.dgvpai.Name = "dgvpai";
            this.dgvpai.RowHeadersVisible = false;
            this.dgvpai.RowTemplate.Height = 23;
            this.dgvpai.Size = new System.Drawing.Size(471, 416);
            this.dgvpai.TabIndex = 33;
            // 
            // sing_name
            // 
            this.sing_name.DataPropertyName = "song_name";
            this.sing_name.HeaderText = "歌曲";
            this.sing_name.Name = "sing_name";
            // 
            // path
            // 
            this.path.DataPropertyName = "song_url";
            this.path.HeaderText = "路径";
            this.path.Name = "path";
            this.path.Visible = false;
            // 
            // songer_name
            // 
            this.songer_name.DataPropertyName = "singer_name";
            this.songer_name.HeaderText = "歌手";
            this.songer_name.Name = "songer_name";
            // 
            // songer_path
            // 
            this.songer_path.DataPropertyName = "song_play_count";
            this.songer_path.HeaderText = "点歌次数";
            this.songer_path.Name = "songer_path";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.添加ToolStripMenuItem.Text = "添加";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 35);
            this.label1.TabIndex = 34;
            this.label1.Text = "金榜排行";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::KTV.Properties.Resources.a_4;
            this.pictureBox1.Location = new System.Drawing.Point(424, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 47);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 477);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvpai);
            this.Name = "frmPai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpai)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sing_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn songer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn songer_path;
    }
}