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
using System.IO;

namespace MyKTV.frm
{
    public partial class FrmEditSong : Form
    {
        DBHelper dbHelper = new DBHelper();
        DataSet ds = new DataSet();
        private enum Model
        {
            Modify, Add
        }
        private Model once;
        private string song_id;
        public FrmEditSong()
        {
            once = Model.Add;
            InitializeComponent();
            Load_cboSongType();
        }
        public FrmEditSong(string song_id)
        {
            this.song_id = song_id;
            once = Model.Modify;
            InitializeComponent();
            Load_cboSongType();
            Load_Control();
        }      
        //修改模式对各个控件进行初始化
        private void Load_Control()
        {
            SqlDataReader reader = null;
            try
            {
                dbHelper.OpenConn();
                reader = new SqlCommand("SELECT * FROM song_info o ,singer_info i WHERE o.singer_id=i.singer_id AND o.song_id=" + this.song_id, dbHelper.Conn).ExecuteReader();
                while (reader.Read())
                {
                    this.txtSongName.Text = reader["song_name"].ToString();
                    this.txtSongPinYin.Text = reader["song_ab"].ToString();
                    this.cboSongType.SelectedIndex = int.Parse(reader["song_songtype_id"].ToString());
                    this.txtSongerName.Text = reader["singer_name"].ToString();
                    this.txtSongFolderName.Text = CopyFile.SourcePath  +"\\"+ reader["song_url"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                reader.Close();
                dbHelper.CloseConn();
            }
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

            this.cboSongType.ValueMember = "songtype_id";
            this.cboSongType.DisplayMember = "songtype_name";
            this.cboSongType.DataSource = ds.Tables["SongType"];
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                if (CopyFile.ToCopyFile(this.txtSongFolderName.Text))
                {
                    try
                    {
                        dbHelper.OpenConn();
                        if (once == Model.Add)
                        {
                            if (new SqlCommand("INSERT song_info SELECT '" + this.txtSongName.Text + "','" + this.txtSongPinYin.Text + "'," + this.txtSongName.Text.Length + "," + this.cboSongType.SelectedValue + "," + new SqlCommand("SELECT singer_id FROM singer_info WHERE singer_name = '" + this.txtSongerName.Text + "'", dbHelper.Conn).ExecuteScalar().ToString() + ",'" + Path.GetFileName(this.txtSongFolderName.Text) + "',0", dbHelper.Conn).ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("添加成功！！！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("未知错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (new SqlCommand("UPDATE song_info SET song_name='" + this.txtSongName.Text + "',song_ab='" + this.txtSongPinYin.Text + "',song_word_count=" + this.txtSongName.Text.Length + ",singer_id=" + new SqlCommand("SELECT singer_id FROM singer_info WHERE singer_name = '" + this.txtSongerName.Text + "'", dbHelper.Conn).ExecuteScalar().ToString() + ",song_songtype_id=" + this.cboSongType.SelectedValue + ",song_url='" + Path.GetFileName(this.txtSongFolderName.Text) + "' WHERE song_id=" + this.song_id, dbHelper.Conn).ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("修改成功！！！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("未知错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }
                else
                {
                    MessageBox.Show("文件复制失败!!");
                }
               
            }
            else
            {
                MessageBox.Show("请填写完整的歌曲信息！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //验证输入
        private Boolean Check_Input()
        {
            if(String.IsNullOrEmpty(this.txtSongerName.Text)|| String.IsNullOrEmpty(this.txtSongFolderName.Text) || String.IsNullOrEmpty(this.txtSongName.Text) || String.IsNullOrEmpty(this.txtSongPinYin.Text) || this.cboSongType.Text.Equals("请选择"))
            {
                return false;
            }
            return true;
        }
        //浏览歌曲文件名地址
        private void btnLook_Click(object sender, EventArgs e)
        {
            this.ofdLookSong.ShowDialog();
            this.txtSongFolderName.Text = this.ofdLookSong.FileName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearchSonger frmSearchSonger = new FrmSearchSonger(null);
            frmSearchSonger.ShowDialog();
            this.txtSongerName.Text = frmSearchSonger.SelectSonger();
        }
    }
}
