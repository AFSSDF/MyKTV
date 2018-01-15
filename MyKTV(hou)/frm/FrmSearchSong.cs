using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyKTV.sys;
using System.Data.SqlClient;

namespace MyKTV.frm
{
    public partial class FrmSearchSong : Form
    {
        DBHelper dbHelper = new DBHelper();
        DataSet ds = new DataSet();
        SqlDataAdapter adapterSong;
        public FrmSearchSong()
        {
            InitializeComponent();
        }

        private void FrmAddSong_Load(object sender, EventArgs e)
        {
            Load_cboSongType();
            Load_dgvSongList();
            Load_ctmsSongMenu();
            FillTable();
        }
        //加载右键菜单
        private void Load_ctmsSongMenu()
        {
            this.ctmsSongMenu.Items.Add("修改", null, ctm_Modify);
            this.ctmsSongMenu.Items.Add("删除", null, ctm_DELETE);
            this.dgvSongList.ContextMenuStrip = ctmsSongMenu;
        }

        //加载歌曲列表下拉系列表框
        private void Load_cboSongType()
        {
            SqlDataAdapter adapterSongType = new SqlDataAdapter("SELECT * FROM song_type", dbHelper.Conn);
            adapterSongType.Fill(ds, "SongType");

            DataRow row = ds.Tables["SongType"].NewRow();
            row["songtype_id"] = 0;
            row["songtype_name"] = "请选择";
            ds.Tables["SongType"].Rows.InsertAt(row, 0);

            this.cboType.ValueMember = "songtype_id";
            this.cboType.DisplayMember = "songtype_name";
            this.cboType.DataSource = ds.Tables["SongType"];
        }
        //加载dgvSongList
        private void Load_dgvSongList()
        {
            this.dgvSongList.Columns.Add("song_id", "");
            this.dgvSongList.Columns.Add("song_name", "歌曲名");
            this.dgvSongList.Columns.Add("songtype_name", "歌曲类别");
            this.dgvSongList.Columns.Add("song_play_count", "点播次数");
            for (int i = 0; i < dgvSongList.ColumnCount; i++)
            {
                dgvSongList.Columns[i].DataPropertyName = dgvSongList.Columns[i].Name;
            }
            this.dgvSongList.AutoGenerateColumns = false;
            this.dgvSongList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongList.MultiSelect = false;
            this.dgvSongList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongList.AllowUserToAddRows = false;
            this.dgvSongList.Columns[0].Visible = false;
        }
        //对dgvSongList进行绑定
        private void FillTable()
        {
            ClearTable();
            adapterSong = new SqlDataAdapter("SELECT * FROM song_info i,song_type t WHERE i.[song_songtype_id]=t.[songtype_id]", dbHelper.Conn);
            adapterSong.Fill(ds, "SongInfo");
            this.dgvSongList.DataSource = ds.Tables["SongInfo"];
        }
        //对dgvSongList进行清除
        private void ClearTable()
        {
            if (ds.Tables["SongInfo"] != null)
            {
                ds.Tables["SongInfo"].Clear();
            }
        }
        //对dgvSongList进行筛选
        private void Filter()
        {
            DataView dv = new DataView(ds.Tables["SongInfo"]);
            if (this.cboType.Text.Equals("请选择"))
            {
                dv.RowFilter = "song_name like '%" + this.txtName.Text + "%'";
            }
            else
            {
                dv.RowFilter = "song_name like '%" + this.txtName.Text + "%' and songtype_name like '%" + this.cboType.Text + "%'";
            }
            this.dgvSongList.DataSource = dv;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FillTable();
            Filter();
        }

        private void ctm_Modify(object sender, EventArgs e)
        {
            FrmEditSong frmEditSong = new FrmEditSong(this.dgvSongList.SelectedRows[0].Cells["song_id"].Value.ToString());
            frmEditSong.ShowDialog();
            FillTable();
            Filter();
        }
        private void ctm_DELETE(object sender, EventArgs e)
        {
            try
            {
                dbHelper.OpenConn();
                if (MessageBox.Show("确认删除吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (new SqlCommand("DELETE FROM song_info WHERE song_id=" + this.dgvSongList.SelectedRows[0].Cells["song_id"].Value.ToString(), dbHelper.Conn).ExecuteNonQuery() == 1 )
                    {
                        MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("未知错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            FillTable();
            Filter();
        }
    }
}
