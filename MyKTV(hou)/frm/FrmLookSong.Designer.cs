namespace MyKTV.frm
{
    partial class FrmLookSong
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
            this.lblOldPath = new System.Windows.Forms.Label();
            this.lblNewPath = new System.Windows.Forms.Label();
            this.txtOldPath = new System.Windows.Forms.TextBox();
            this.txtNewPath = new System.Windows.Forms.TextBox();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.fbdLook = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblOldPath
            // 
            this.lblOldPath.AutoSize = true;
            this.lblOldPath.Location = new System.Drawing.Point(74, 35);
            this.lblOldPath.Name = "lblOldPath";
            this.lblOldPath.Size = new System.Drawing.Size(53, 12);
            this.lblOldPath.TabIndex = 0;
            this.lblOldPath.Text = "当前路径";
            // 
            // lblNewPath
            // 
            this.lblNewPath.AutoSize = true;
            this.lblNewPath.Location = new System.Drawing.Point(86, 87);
            this.lblNewPath.Name = "lblNewPath";
            this.lblNewPath.Size = new System.Drawing.Size(41, 12);
            this.lblNewPath.TabIndex = 1;
            this.lblNewPath.Text = "新路径";
            // 
            // txtOldPath
            // 
            this.txtOldPath.Location = new System.Drawing.Point(142, 32);
            this.txtOldPath.Name = "txtOldPath";
            this.txtOldPath.Size = new System.Drawing.Size(334, 21);
            this.txtOldPath.TabIndex = 2;
            // 
            // txtNewPath
            // 
            this.txtNewPath.Location = new System.Drawing.Point(142, 84);
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.Size = new System.Drawing.Size(334, 21);
            this.txtNewPath.TabIndex = 3;
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(52, 123);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(75, 23);
            this.btnLook.TabIndex = 4;
            this.btnLook.Text = "浏览";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(356, 123);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(75, 23);
            this.btnMake.TabIndex = 5;
            this.btnMake.Text = "保存";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(502, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "取消";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmLookSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 179);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.txtNewPath);
            this.Controls.Add(this.txtOldPath);
            this.Controls.Add(this.lblNewPath);
            this.Controls.Add(this.lblOldPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLookSong";
            this.Text = "设置歌曲路径";
            this.Load += new System.EventHandler(this.FrmLookSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPath;
        private System.Windows.Forms.Label lblNewPath;
        private System.Windows.Forms.TextBox txtOldPath;
        private System.Windows.Forms.TextBox txtNewPath;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.FolderBrowserDialog fbdLook;
    }
}