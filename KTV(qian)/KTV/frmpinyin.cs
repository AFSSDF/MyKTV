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
    public partial class frmpinyin : Form
    {
        DBHelper dbhelper = new DBHelper();
        DataSet da = new DataSet();
        SqlDataAdapter adapter = null;
        public frmpinyin()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            string cha1 = this.textBox1.Text.Trim();//获得查询信息  
            try
            {
                if (da.Tables["stu"] != null)
                {
                    da.Tables["stu"].Clear();
                }
                //sb.AppendLine("");
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("select * from singer_info as e,song_info  as i where e.singer_id=i.singer_id and  song_name like '%{0}%'  or e.singer_id=i.singer_id and song_ab like '{0}%'", cha1);
                //dv.RowFilter = string.Format("song_name like '%{0}%'", cha);
                adapter = new SqlDataAdapter(sb.ToString(), dbhelper.Conn);

                adapter.Fill(da, "stu");

                dgvge.DataSource = da.Tables["stu"];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }//按名称查询歌曲 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox label = (PictureBox)sender;
            switch (label.Name)
            {
                case "pictureBox1":
                    textBox1.Text = textBox1.Text + "A"; ;

                    break;
                case "pictureBox2":
                    textBox1.Text = textBox1.Text + "B"; ;
                    break;
                case "pictureBox3":
                    textBox1.Text = textBox1.Text + "C"; ;
                    break;
                case "pictureBox4":
                    textBox1.Text = textBox1.Text + "D"; ;
                    break;
                case "pictureBox5":
                    textBox1.Text = textBox1.Text + "E"; ;
                    break;
                case "pictureBox7":
                    textBox1.Text = textBox1.Text + "F"; ;
                    break;
                case "pictureBox10":
                    textBox1.Text = textBox1.Text + "G"; ;
                    break;
                case "pictureBox8":
                    textBox1.Text = textBox1.Text + "H"; ;
                    break;
                case "pictureBox11":
                    textBox1.Text = textBox1.Text + "I"; ;
                    break;
                case "pictureBox18":
                    textBox1.Text = textBox1.Text + "J"; ;
                    break;
                case "pictureBox9":
                    textBox1.Text = textBox1.Text + "K"; ;
                    break;
                case "pictureBox12":
                    textBox1.Text = textBox1.Text + "L"; ;
                    break;
                case "pictureBox15":
                    textBox1.Text = textBox1.Text + "M"; ;
                    break;
                case "pictureBox13":
                    textBox1.Text = textBox1.Text + "N"; ;
                    break;
                case "pictureBox16":
                    textBox1.Text = textBox1.Text + "O"; ;
                    break;
                case "pictureBox23":
                    textBox1.Text = textBox1.Text + "P"; ;
                    break;
                case "pictureBox22":
                    textBox1.Text = textBox1.Text + "Q"; ;
                    break;
                case "pictureBox25":
                    textBox1.Text = textBox1.Text + "R"; ;
                    break;
                case "pictureBox26":
                    textBox1.Text = textBox1.Text + "S"; ;
                    break;
                case "pictureBox24":
                    textBox1.Text = textBox1.Text + "T"; ;
                    break;
                case "pictureBox14":
                    textBox1.Text = textBox1.Text + "U"; ;
                    break;
                case "pictureBox17":
                    textBox1.Text = textBox1.Text + "V"; ;
                    break;
                case "pictureBox20":
                    textBox1.Text = textBox1.Text + "W"; ;
                    break;
                case "pictureBox21":
                    textBox1.Text = textBox1.Text + "X"; ;
                    break;
                case "pictureBox19":
                    textBox1.Text = textBox1.Text + "Y"; ;
                    break;
                case "pictureBox6":
                    textBox1.Text = textBox1.Text + "Z"; ;
                    break;
            }
        }//点击字母输入

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string strTemp = textBox1.Text.Trim();
                textBox1.Text = strTemp.Substring(0, strTemp.Length - 1);
            }
           
        
            //textBox1.Clear();
        }
         //清空
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string strTemp = textBox1.Text.Trim();
                textBox1.Text = strTemp.Substring(0, strTemp.Length - 1);
            }
           
        }
        //退出
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //窗体加载事件
        private void frmpinyin_Load(object sender, EventArgs e)
        {
            this.dgvge.AutoGenerateColumns = false;
            this.dgvge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvge.MultiSelect = false;
            this.dgvge.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvge.AllowUserToAddRows = false;

        }
        //添加
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MvInfo mv1 = new MvInfo();
            mv1.singer_name = this.dgvge.SelectedRows[0].Cells["Column2"].Value.ToString();
            mv1.song_name = this.dgvge.SelectedRows[0].Cells["Column1"].Value.ToString();
            mv1.mv_path = ControlEnd.MainPath + this.dgvge.SelectedRows[0].Cells["path"].Value.ToString();
            ControlEnd.addMvInfo(mv1);
            Dain();
        }
        //增加点歌次数
        public void Dain()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("update song_info set song_play_count+=1 where song_name ='{0}'", this.dgvge.SelectedRows[0].Cells[0].Value.ToString());
            SqlCommand comm = new SqlCommand(sb.ToString(), dbhelper.Conn);
            try
            {
                dbhelper.OpenConn();
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {

                }
            }
            catch
            {
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}