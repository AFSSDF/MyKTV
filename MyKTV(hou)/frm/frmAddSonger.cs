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
    public partial class frmAddSonger : Form
    {
        public frmAddSonger()
        {
            InitializeComponent();           
        }
        //窗体加载事件
        private void frmAddSonger_Load(object sender, EventArgs e)
        {
            if(this.Tag!=null)
            {
                this.button3.Text = "修改";
                bing();    //绑定歌手类型
                chuan();//传值
            }
            else
            {
                bing();    //绑定歌手类型
            }
           
        }
        DBHelper dbhelper = new DBHelper();
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;
        //绑定歌手类型
        public void bing()
        {
            string sql = string.Format(@"select * from singer_type");
            adapter = new SqlDataAdapter(sql, dbhelper.Conn);
            adapter.Fill(ds, "Lei");

            DataRow row = ds.Tables["Lei"].NewRow();
            row["singertype_id"] = 0;
            row["singertype_name"] = "请选择";
            ds.Tables["Lei"].Rows.InsertAt(row, 0);
            //cboLei.Items.Add("请选择");
            cboLei.ValueMember = "singertype_id";
            cboLei.DisplayMember = "singertype_name";
            cboLei.DataSource = ds.Tables["Lei"];
        }
        //浏览
        private void button1_Click(object sender, EventArgs e)
        {
            this.ofdLooksonger.ShowDialog();
            try
            {
                picPhoto.Image = Image.FromFile(this.ofdLooksonger.FileName);
            }
            catch
            {
            }
        }
        //添加事件
        public bool add()
        {
            string sex = " ";
            if (rdoMan.Checked == true)
            {
                sex = "男";
            }
            else if (rdoGilr.Checked == true)
            {
                sex = "女";
            }
            else
            {
                sex = "组合";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into singer_info (singer_name,singertype_id,singer_sex,singer_photo_url , singer_miao)");
            sb.AppendFormat("values ('{0}',{1},'{2}','{3}','{4}')", txtname.Text, cboLei.SelectedIndex, sex, txtMiao.Text, Path.GetFileName(this.ofdLooksonger.FileName.ToString()));
            SqlCommand comm = new SqlCommand(sb.ToString(), dbhelper.Conn);
           
            try
            {
                dbhelper.OpenConn();
                int i = comm.ExecuteNonQuery();

                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                    //MessageBox.Show("错误！", "提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                dbhelper.CloseConn();
            }
            return false;
        }
        //保存预览图片
        //public bool addphoto()
        //{
        //    string sql = string.Format("insert into resoure_path (resoure_type,resoure_path) values ('img','{0}')", this.ofdLooksonger.FileName.ToString());
        //    SqlCommand comm = new SqlCommand(sql, dbhelper.Conn);
        //    try
        //    {
        //        dbhelper.OpenConn();
        //        int i = comm.ExecuteNonQuery();

        //        if (i > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        dbhelper.CloseConn();
        //    }
        //    return false;

        //}
        //非空验证
        public bool Yan()
        {
            if (string.IsNullOrEmpty(txtname.Text) || cboLei.SelectedIndex == 0)
            {
                MessageBox.Show("请输入完整信息！", "提示");
                return false;
            }
            return true;
        }
        //添加按钮
        private void button3_Click(object sender, EventArgs e)
        {
            if (Yan())
            {
                if (CopyFile.ToCopyFile(this.ofdLooksonger.FileName.ToString()))
                {
                    if (this.Tag != null)
                    {
                        if (update())
                        {
                            MessageBox.Show("修改成功！");
                        }
                        else
                        {
                            MessageBox.Show("未知错误！");
                        }
                    }
                    else if (add())
                    {
                        MessageBox.Show("保存成功！");
                    }
                    else
                    {
                        MessageBox.Show("未知错误！");
                    }
                }
                else
                {
                    MessageBox.Show("添加文件失败");
                }
            }
        }
        //修改歌手信息
        public bool update()
        {
            string sex=" ";
           if (rdoMan.Checked == true)
            {
                sex = "男";
            }
            else if (rdoGilr.Checked == true)
            {
                sex = "女";
            }
            else
            { 
                sex ="组合";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("update singer_info set singer_name='{0}' ,singertype_id= {1},singer_sex='{2}',singer_photo_url='{3}',singer_miao='{4}'", txtname.Text, cboLei.SelectedIndex.ToString(), sex, txtMiao.Text, Path.GetFileName(this.ofdLooksonger.FileName.ToString()));
            sb.AppendFormat(" where singer_id={0}",this.Tag);
            SqlCommand comm = new SqlCommand(sb.ToString(),dbhelper.Conn);
            try
            {
                dbhelper.OpenConn();
                int i = comm.ExecuteNonQuery();
                if(i>0)
                {
                    return true;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                dbhelper.CloseConn();
            }
            return false;
        }
        //传值
        public void chuan()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select singer_name,singertype_name,singer_sex,singer_photo_url,singer_miao");
            sb.AppendLine("from dbo.singer_info as i ,dbo.singer_type as t");
            sb.AppendFormat("where t.singertype_id=i.singertype_id and singer_id={0}", this.Tag);
            SqlCommand comm = new SqlCommand(sb.ToString(),dbhelper.Conn);
            try
            {
                dbhelper.OpenConn();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    txtname.Text = reader["singer_name"].ToString();
                    cboLei.Text = reader["singertype_name"].ToString();
                    if (reader["singer_sex"].ToString() == "男")
                    {
                        rdoMan.Checked = true;                      
                    }
                    else if (reader["singer_sex"].ToString() == "女")
                    {
                        rdoGilr.Checked = true;
                    }
                    else
                    {
                        rdoZu.Checked = true;
                    }
                    txtMiao.Text = reader["singer_photo_url"].ToString();
                    picPhoto.Image = Image.FromFile(CopyFile.SourcePath +"\\"+ reader["singer_miao"].ToString());
                }

                reader.Close();
                
            }
            catch 
            {
            
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
    

