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
    public partial class frmPai : Form
    {
        DBHelper dbhelper = new DBHelper();
        DataSet ds = new DataSet();
        public frmPai()
        {
            InitializeComponent();
        }
        //退出
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //已点
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //frmyidian yd = new frmyidian();
        }
        //主页面
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmzhuye zhu = new frmzhuye();
            zhu.Show();
        }
        //窗体加载事件
        private void frmPai_Load(object sender, EventArgs e)
        {
          
            this.dgvpai.AutoGenerateColumns = false;
            this.dgvpai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpai.MultiSelect = false;
            this.dgvpai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvpai.AllowUserToAddRows = false;
            pai();

        }
        //排行
        public void pai()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select *");
            sb.AppendLine("from singer_info as e,song_info as s");
            sb.AppendLine("where e.singer_id=s.singer_id  ORDER BY song_play_count desc");

            SqlDataAdapter adapter = new SqlDataAdapter(sb.ToString(),dbhelper.Conn);
            try
            {
                adapter.Fill(ds,"pai");

                dgvpai.DataSource = ds.Tables["pai"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //添加
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MvInfo mv1 = new MvInfo(); 
            mv1.singer_name = this.dgvpai.SelectedRows[0].Cells["songer_name"].Value.ToString();
            mv1.song_name = this.dgvpai.SelectedRows[0].Cells["sing_name"].Value.ToString();
            mv1.mv_path = ControlEnd.MainPath + this.dgvpai.SelectedRows[0].Cells["path"].Value.ToString();
            ControlEnd.addMvInfo(mv1);
            Dain();
        }
        //增加点歌次数
        public void Dain()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("update song_info set song_play_count+=1 where song_name ='{0}'", this.dgvpai.SelectedRows[0].Cells[0].Value.ToString());
            SqlCommand comm = new SqlCommand(sb.ToString(), dbhelper.Conn);
            try
            {

                dbhelper.OpenConn();
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {}
            }
            catch
            {
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
