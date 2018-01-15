namespace MyKTV.frm
{
    partial class FrmSearchSonger
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboLei = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvsonger = new System.Windows.Forms.DataGridView();
            this.songer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songLei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singerSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songerMiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsonger)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "歌手姓名";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(90, 29);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "歌手类型";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboLei
            // 
            this.cboLei.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLei.FormattingEnabled = true;
            this.cboLei.Location = new System.Drawing.Point(274, 29);
            this.cboLei.Name = "cboLei";
            this.cboLei.Size = new System.Drawing.Size(169, 20);
            this.cboLei.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // dgvsonger
            // 
            this.dgvsonger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsonger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsonger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songer,
            this.id,
            this.songLei,
            this.singerSex,
            this.songerMiao});
            this.dgvsonger.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvsonger.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvsonger.Location = new System.Drawing.Point(0, 74);
            this.dgvsonger.Name = "dgvsonger";
            this.dgvsonger.RowHeadersVisible = false;
            this.dgvsonger.RowTemplate.Height = 23;
            this.dgvsonger.Size = new System.Drawing.Size(573, 342);
            this.dgvsonger.TabIndex = 1;
            // 
            // songer
            // 
            this.songer.DataPropertyName = "singer_name";
            this.songer.HeaderText = "歌手姓名";
            this.songer.Name = "songer";
            this.songer.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "singer_id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // songLei
            // 
            this.songLei.DataPropertyName = "singertype_name";
            this.songLei.HeaderText = "歌手类别";
            this.songLei.Name = "songLei";
            this.songLei.ReadOnly = true;
            // 
            // singerSex
            // 
            this.singerSex.DataPropertyName = "singer_sex";
            this.singerSex.HeaderText = "歌手性别";
            this.singerSex.Name = "singerSex";
            this.singerSex.ReadOnly = true;
            // 
            // songerMiao
            // 
            this.songerMiao.DataPropertyName = "singer_photo_url";
            this.songerMiao.HeaderText = "歌手描述";
            this.songerMiao.Name = "songerMiao";
            // 
            // FrmSearchSonger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 416);
            this.Controls.Add(this.cboLei);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.dgvsonger);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSearchSonger";
            this.Text = "新增歌手";
            this.Load += new System.EventHandler(this.FrmSearchSonger_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsonger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboLei;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvsonger;
        private System.Windows.Forms.DataGridViewTextBoxColumn songer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn songLei;
        private System.Windows.Forms.DataGridViewTextBoxColumn singerSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn songerMiao;
    }
}