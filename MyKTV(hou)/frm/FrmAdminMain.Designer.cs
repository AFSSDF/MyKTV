namespace MyKTV.frm
{
    partial class FrmAdminMain
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.歌手管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增歌手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询歌手信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.歌曲管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增歌曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询歌曲信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置资源路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.歌手管理ToolStripMenuItem,
            this.歌曲管理ToolStripMenuItem,
            this.设置资源路径ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.帮助ToolStripMenuItem1});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(720, 25);
            this.msMainMenu.TabIndex = 2;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // 歌手管理ToolStripMenuItem
            // 
            this.歌手管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增歌手ToolStripMenuItem,
            this.查询歌手信息ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.歌手管理ToolStripMenuItem.Name = "歌手管理ToolStripMenuItem";
            this.歌手管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.歌手管理ToolStripMenuItem.Text = "歌手管理";
            // 
            // 新增歌手ToolStripMenuItem
            // 
            this.新增歌手ToolStripMenuItem.Name = "新增歌手ToolStripMenuItem";
            this.新增歌手ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.新增歌手ToolStripMenuItem.Text = "新增歌手";
            this.新增歌手ToolStripMenuItem.Click += new System.EventHandler(this.新增歌手ToolStripMenuItem_Click);
            // 
            // 查询歌手信息ToolStripMenuItem
            // 
            this.查询歌手信息ToolStripMenuItem.Name = "查询歌手信息ToolStripMenuItem";
            this.查询歌手信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查询歌手信息ToolStripMenuItem.Text = "查询歌手信息";
            this.查询歌手信息ToolStripMenuItem.Click += new System.EventHandler(this.查询歌手信息ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 歌曲管理ToolStripMenuItem
            // 
            this.歌曲管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增歌曲ToolStripMenuItem,
            this.查询歌曲信息ToolStripMenuItem});
            this.歌曲管理ToolStripMenuItem.Name = "歌曲管理ToolStripMenuItem";
            this.歌曲管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.歌曲管理ToolStripMenuItem.Text = "歌曲管理";
            // 
            // 新增歌曲ToolStripMenuItem
            // 
            this.新增歌曲ToolStripMenuItem.Name = "新增歌曲ToolStripMenuItem";
            this.新增歌曲ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.新增歌曲ToolStripMenuItem.Text = "新增歌曲";
            this.新增歌曲ToolStripMenuItem.Click += new System.EventHandler(this.新增歌曲ToolStripMenuItem_Click);
            // 
            // 查询歌曲信息ToolStripMenuItem
            // 
            this.查询歌曲信息ToolStripMenuItem.Name = "查询歌曲信息ToolStripMenuItem";
            this.查询歌曲信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查询歌曲信息ToolStripMenuItem.Text = "查询歌曲信息";
            this.查询歌曲信息ToolStripMenuItem.Click += new System.EventHandler(this.查询歌曲信息ToolStripMenuItem_Click);
            // 
            // 设置资源路径ToolStripMenuItem
            // 
            this.设置资源路径ToolStripMenuItem.Name = "设置资源路径ToolStripMenuItem";
            this.设置资源路径ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.设置资源路径ToolStripMenuItem.Text = "设置资源路径";
            this.设置资源路径ToolStripMenuItem.Click += new System.EventHandler(this.设置资源路径ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.帮助ToolStripMenuItem.Text = "收缩资源空间";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 372);
            this.Controls.Add(this.msMainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "FrmAdminMain";
            this.Text = "KTV后台管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdminMain_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem 歌手管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增歌手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询歌手信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 歌曲管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增歌曲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询歌曲信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置资源路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}