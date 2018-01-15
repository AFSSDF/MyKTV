using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyKTV.sys;
using System.IO;

namespace MyKTV.frm
{
    public partial class FrmLookSong : Form
    {
        DBHelper dbHelper = new DBHelper();
        public string oldPath;
        public FrmLookSong()
        {
            InitializeComponent();
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            this.fbdLook.ShowDialog();
            this.txtNewPath.Text = this.fbdLook.SelectedPath;
        }

        private void FrmLookSong_Load(object sender, EventArgs e)
        {
            try
            {
                dbHelper.OpenConn();
                this.txtOldPath.Text = new SqlCommand("SELECT resoure_path FROM resoure_path WHERE resoure_type='main'", dbHelper.Conn).ExecuteScalar().ToString();
                this.oldPath = this.txtOldPath.Text;
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

        private void btnMake_Click(object sender, EventArgs e)
        {
                try
                {
                    dbHelper.OpenConn();
                    if (!String.IsNullOrEmpty(this.txtNewPath.Text))
                    {
                        if (new SqlCommand("UPDATE resoure_path SET resoure_path='" + this.txtNewPath.Text + "' WHERE resoure_type='main'", dbHelper.Conn).ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("修改成功！！！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("修改失败！！！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请填写完整的信息！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    dbHelper.CloseConn();
                }
                FrmAdminMain.Load_SourcePath();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
