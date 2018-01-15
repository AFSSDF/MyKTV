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
    public partial class frmfeilei : Form
    {
        DBHelper dbhelper = new DBHelper();
        DataSet ds = new DataSet();
        public frmfeilei()
        {
            InitializeComponent();
        }
        //点击事件
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearTable();
            PictureBox picturebox = (PictureBox)sender;
            //MessageBox.Show(Convert.ToString(picturebox.Tag));

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select *");
            sb.AppendLine("from dbo.song_info as s,dbo.singer_info as e");
            sb.AppendFormat("where e.singer_id=s.singer_id and song_songtype_id={0}", Convert.ToString(picturebox.Tag));

            SqlDataAdapter adapter = new SqlDataAdapter(sb.ToString(), dbhelper.Conn);
            adapter.Fill(ds, "leige");
            dgvpai.DataSource = ds.Tables["leige"];
        }
        private void ClearTable()
        {
            if (ds.Tables["leige"] != null)
            {
                ds.Tables["leige"].Clear();
            }
        }
        //窗体加载
        private void frmfeilei_Load(object sender, EventArgs e)
        {
            this.dgvpai.AutoGenerateColumns = false;
            this.dgvpai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpai.MultiSelect = false;
            this.dgvpai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvpai.AllowUserToAddRows = false;
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
            //yd.Show();
        }
        //主界面
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmzhuye zy = new frmzhuye();
            zy.Show();
        }
        
        //重唱
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            ControlEnd.setCmd(ExCmd.CMD_RESET);
        }
        //切歌
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            ControlEnd.setCmd(ExCmd.CMD_NEXT);
        }
        //已点
        private void toolStripButton13_Click(object sender, EventArgs e)
        {

        }
         //服务
        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂未服务");
        }
        //添加
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MvInfo mv1 = new MvInfo();
            //MessageBox.Show(this.dgvpai.SelectedRows[0].Cells[0].Value.ToString());
            mv1.singer_name = this.dgvpai.SelectedRows[0].Cells["songer_name"].Value.ToString();
            mv1.song_name = this.dgvpai.SelectedRows[0].Cells["sing_name"].Value.ToString();
            mv1.mv_path = ControlEnd.MainPath+this.dgvpai.SelectedRows[0].Cells["songer_path"].Value.ToString();
            //MessageBox.Show(mv1.mv_path);
            ControlEnd.addMvInfo(mv1);
            Dain();  //增加点歌次数
        }
        //增加点歌次数
        public void Dain()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("update song_info set song_play_count+=1 where song_name ='{0}'", this.dgvpai.SelectedRows[0].Cells[0].Value.ToString());
            SqlCommand comm = new SqlCommand(sb.ToString(),dbhelper.Conn);        
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
        //退出
        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
