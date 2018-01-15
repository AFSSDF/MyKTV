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
using System.Data;
using MyKTV.sys;

namespace MyKTV.frm
{
    public partial class FrmSearchSonger : Form
    {
        public FrmSearchSonger()
        {
            InitializeComponent();
        }

        public FrmSearchSonger(String e)
        {
            InitializeComponent();
            dgvsonger.CellContentDoubleClick += new DataGridViewCellEventHandler(SelectSonger);
        }
        private void SelectSonger(object sender, EventArgs e)
        {
            this.dgvsonger.ReadOnly = true;
            this.Close();
        }

        public string SelectSonger()
        {
            return this.dgvsonger.SelectedRows[0].Cells["songer"].Value.ToString();
        }
        //窗体加载事件
        private void FrmSearchSonger_Load(object sender, EventArgs e)
        {
            Bing();//绑定歌手类型
            dgv();//dgv属性
            Song();
        }
        DataSet ds = new DataSet();
        DBHelper dbhelper = new DBHelper();
        SqlDataAdapter adapter;
        //绑定歌手类型
        public void Bing()
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
        //dgv属性
        public void dgv()
        {
            this.dgvsonger.AutoGenerateColumns = false;
            this.dgvsonger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsonger.MultiSelect = false;
            this.dgvsonger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvsonger.AllowUserToAddRows = false;

        }
        //dgv 绑定 查询
        public void Song()
        {
            ClearTable();
            int gradeid = Convert.ToInt32(cboLei.SelectedIndex);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select *");
            sb.AppendLine("from singer_info as i ,dbo.singer_type as t");
            sb.AppendFormat(" where i.singertype_id=t.singertype_id and  singer_name like '%{0}%'", txtname.Text);
            //sb.AppendFormat(" and singer_name like '%{0}%' and t.singertype_id={1}", txtname.Text, cboLei.SelectedValue);

            try
            {
                if (txtname.Text != null && cboLei.SelectedIndex!=0)
                {
                    sb.AppendFormat("and t.singertype_id={0}", cboLei.SelectedValue);
                }
                adapter = new SqlDataAdapter(sb.ToString(), dbhelper.Conn);
                adapter.Fill(ds, "song");

                dgvsonger.DataSource = ds.Tables["song"];
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
        //对dgvSongList进行清除
        private void ClearTable()
        {
            if (ds.Tables["song"] != null)
            {
                ds.Tables["song"].Clear();
            }
        }

        //查询事件
        private void button1_Click(object sender, EventArgs e)
        {
            Song();
        }
        //右键菜单删除事件
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要删除该歌曲吗？","提示！",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

            if(result==DialogResult.OK)
            {
                delete();
            }
           
        }
        //删除方法
        public void delete()
        {
          
            string sql = string.Format("Delete  from singer_info where singer_id ='{0}'", this.dgvsonger.SelectedRows[0].Cells["id"].Value.ToString());
            SqlCommand comm = new SqlCommand(sql, dbhelper.Conn);
            try
            {
                dbhelper.OpenConn();
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("删除成功！", "提示");
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示");
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally
            {
                dbhelper.CloseConn();
            }
            ClearTable();
            Song();
        }
        //修改歌手信息
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSonger add = new frmAddSonger();
            add.Tag = this.dgvsonger.SelectedRows[0].Cells["id"].Value.ToString();
            add.ShowDialog();
            ClearTable();
            Song();
        }
    }
}
