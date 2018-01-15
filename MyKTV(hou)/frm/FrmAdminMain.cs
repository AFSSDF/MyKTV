using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyKTV.frm;
using MyKTV.sys;
using System.Data.SqlClient;

namespace MyKTV.frm
{
    public partial class FrmAdminMain : Form
    {
        static DBHelper dbHelper = new DBHelper();
        public FrmAdminMain()
        {
            InitializeComponent();
        }

        private void 新增歌手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSonger frmAddSonger = new frmAddSonger();
            frmAddSonger.MdiParent = this;
            frmAddSonger.Show();
        }

        private void 查询歌手信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchSonger frmSearchSonger = new FrmSearchSonger();
            frmSearchSonger.MdiParent = this;
            frmSearchSonger.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新增歌曲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditSong frmEditSong = new FrmEditSong();
            frmEditSong.MdiParent = this;
            frmEditSong.Show();
        }

        private void 查询歌曲信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchSong frmSearchSong = new FrmSearchSong();
            frmSearchSong.MdiParent = this;
            frmSearchSong.Show();
        }

        private void 设置资源路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLookSong frmLookSong = new FrmLookSong();
            frmLookSong.MdiParent = this;
            frmLookSong.Show();
        }

        private void FrmAdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmAdminMain_Load(object sender, EventArgs e)
        {
            Load_SourcePath();
        }

        public static void Load_SourcePath()
        {
            try
            {
                dbHelper.OpenConn();
                CopyFile.SourcePath= new SqlCommand("SELECT resoure_path FROM resoure_path WHERE resoure_type='main'", dbHelper.Conn).ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                dbHelper.CloseConn();
            }
        }
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shrink shrink = new Shrink();
            shrink.ExShrink();
        }
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmguanyu frmGuanYu = new frmguanyu();
            frmGuanYu.ShowDialog();
        }
    }
}
