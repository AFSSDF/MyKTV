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
    public partial class frmzishu : Form
    {
        DBHelper dbhelper = new DBHelper();
        DataSet ds = new DataSet();
        
        public frmzishu()
        {
            InitializeComponent();
        }
         //已点歌曲
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
            //frmyidian yidian = new frmyidian();
            //yidian.Show();
        }
       //主界面
        private void toolStripButton6_Click(object sender, EventArgs e)
        { 
            frmzhuye zhu = new frmzhuye();
            zhu.Show();
        }
        //返回
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
        int num = 0;
        private void label2_Click(object sender, EventArgs e)
        {
            this.dgvGe.AutoGenerateColumns = false;
            this.dgvGe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGe.MultiSelect = false;
            this.dgvGe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvGe.AllowUserToAddRows = false;
            try
            {
                Label label = (Label)sender;
                //MessageBox.Show(label.Text);
                switch (label.Text)
                {
                    case "1个字":
                        num = 1;
                        break;
                    case "2个字":
                        num = 2;
                        break;
                    case "3个字":
                        num = 3;
                        break;
                    case "4个字":
                        num = 4;

                        break;
                    case "5个字":
                        num = 5;
                        break;
                    case "6个字":
                        num = 6;
                        break;
                    case "7个字":
                        num = 7;
                        break;
                    case "8个字":
                        num = 8;
                        break;
                    case "9个字":
                        num = 9;
                        break;
                    case "10个字":
                        num = 10;
                        break;
                    case "11个字":
                        num = 11;
                        break;
                    case "12个字":
                        num = 12;
                        break;
                }
            }
            catch { };
           if( ds.Tables["ge"] !=null)
           {
               ds.Tables["ge"].Clear();
           }
            Ge();
        }
        //按字数查询结果
            public void Ge()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select *");
                sb.AppendLine("from singer_info as e,song_info as s");
                sb.AppendFormat("where song_word_count={0} and e.singer_id=s.singer_id",num);

                SqlDataAdapter adapter = new SqlDataAdapter(sb.ToString(),dbhelper.Conn);
                try
                {
                    adapter.Fill(ds,"ge");

                    dgvGe.DataSource = ds.Tables["ge"];
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

            private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MvInfo mv1 = new MvInfo();
                mv1.singer_name = this.dgvGe.SelectedRows[0].Cells["songer_name"].Value.ToString();
                mv1.song_name = this.dgvGe.SelectedRows[0].Cells["sing_name"].Value.ToString();
                mv1.mv_path = ControlEnd.MainPath + this.dgvGe.SelectedRows[0].Cells["songer_path"].Value.ToString();
                ControlEnd.addMvInfo(mv1);
                Dain();
            }
            //增加点歌次数
            public void Dain()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("update song_info set song_play_count+=1 where song_name ='{0}'", this.dgvGe.SelectedRows[0].Cells[0].Value.ToString());
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
        //窗体加载事件
            private void frmzishu_Load(object sender, EventArgs e)
            {
                dgvGe.ForeColor = Color.Black;
                this.dgvGe.AutoGenerateColumns = false;
                this.dgvGe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dgvGe.MultiSelect = false;
                this.dgvGe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.dgvGe.AllowUserToAddRows = false;

            }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           dgvGe .ForeColor = Color.Black;
        }
    }
    }

