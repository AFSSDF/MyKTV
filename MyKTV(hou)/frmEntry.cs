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

namespace MyKTV.frm
{
    public partial class frmEntry : Form
    {
        public frmEntry()
        {
            InitializeComponent();
        }
        //加载窗体事件
        private void frmEntry_Load(object sender, EventArgs e)
        {

        }
        DBHelper dbhelper = new DBHelper();
        //登录按钮
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from admin__info ");
            sb.AppendFormat("where admin_pwd= '{0}' and admin_name={1}", txtpwd.Text, txtname.Text);

            SqlCommand comm = new SqlCommand(sb.ToString(), dbhelper.Conn);
            try
            {
                dbhelper.OpenConn();//打开数据库
                int i = Convert.ToInt32(comm.ExecuteScalar());
                if (Yan())
                {
                    if (i > 0)
                    {
                        FrmAdminMain frmAdminMain = new FrmAdminMain();
                        frmAdminMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }
            finally
            {
                dbhelper.CloseConn();//关闭数据库
            }

        }
        //非空验证
        public bool Yan()
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("请输入用户名！");
                return false;
            }
            else
                if (string.IsNullOrEmpty(txtpwd.Text))
                {
                    MessageBox.Show("请输入密码！");
                    return false;
                }
            return true;
        }
        //取消登录
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
