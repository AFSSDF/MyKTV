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
using KTV.sys;

namespace KTV
{
    public partial class frmgexing : Form
    {
        DBHelper dbhelper = new DBHelper();
        DataSet ds = new DataSet();
        public string sex;
        public string address;
        public frmgexing()
        {
            InitializeComponent();
        }
        //主窗体
        private void frmgexing_Load(object sender, EventArgs e)
        {
        }
        //男歌手
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.listView1.Visible = true;
            this.sex = "男";
        }
        //女歌手
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.sex = "女";
        }

        //组合
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.listView1.Visible = true;
            this.sex = "组合";
        }

        //退出
        private void label14_Click(object sender, EventArgs e)
        {
            this.listView1.Visible = true;
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmgexing1 fgx1 = new frmgexing1();
            try
            {
               
                fgx1.Tag = sex + "-" + listView1.SelectedItems[0].Tag;
                fgx1.Show();

                
            }
            catch { }
        }
    }
}
