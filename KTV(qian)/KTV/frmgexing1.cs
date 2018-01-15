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
    public partial class frmgexing1 : Form
    {
        DBHelper dbhelper = new DBHelper();
        DataSet ds = new DataSet();
        public frmgexing1()
        {
            InitializeComponent();
        }

        private void frmgexing1_Load(object sender, EventArgs e)
        {
            this.dgvGex.AutoGenerateColumns = false;
            this.dgvGex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGex.MultiSelect = false;
            this.dgvGex.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvGex.AllowUserToAddRows = false;

            this.label1.Text = this.Tag.ToString();
            this.Text = this.label1.Text;
            Bang();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Bang()
        {
            string[] type = this.label1.Text.Split('-');
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("select singer_name,song_name,song_url,song_play_count from song_info as i,singer_info as e,singer_type as t  where i.singer_id=e.singer_id and t.singertype_id = e.singertype_id and singer_sex='{0}' and singertype_name='{1}'", type[0].ToString(), type[1].ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(sb.ToString(), dbhelper.Conn);
            adapter.Fill(ds, "ge");

            this.dgvGex.DataSource = ds.Tables["ge"];
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MvInfo mv1 = new MvInfo();
            mv1.singer_name = this.dgvGex.SelectedRows[0].Cells["songer_name"].Value.ToString();
            mv1.song_name = this.dgvGex.SelectedRows[0].Cells["sing_name"].Value.ToString();
            mv1.mv_path = ControlEnd.MainPath + this.dgvGex.SelectedRows[0].Cells["songer_path"].Value.ToString();
            ControlEnd.addMvInfo(mv1);
            Dain();
        }
        //增加点歌次数
        public void Dain()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("update song_info set song_play_count+=1 where song_name ='{0}'", this.dgvGex.SelectedRows[0].Cells[0].Value.ToString());
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
    }
}
