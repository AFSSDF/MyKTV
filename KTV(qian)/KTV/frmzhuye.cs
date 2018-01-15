using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV
{
    public partial class frmzhuye : Form
    {
        //KTV ktv = new KTV();
        public frmzhuye()
        {
            InitializeComponent();
        }

        //设置透明
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(10 * 10, 255, 255, 255);
        }
        //退出
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmgexing geshou = new frmgexing();
            geshou.Show();
        }

        //字数
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmzishu zishu = new frmzishu();
            zishu.Show();
        }
       //已点歌曲
        private void toolStripButton3_Click(object sender, EventArgs e)
        { 
            //frmyidian yidian = new frmyidian();
            //yidian.Show();
        }
        //拼音
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmpinyin py = new frmpinyin();
            py.Show();
        }
        //加载事件
        private void frmzhuye_Load(object sender, EventArgs e)
        {
            //权重歌曲列的大小
            this.singer_name.Width = (int)(0.5 * lvMvList.ClientRectangle.Width);
            this.song_name.Width = (int)(0.5 * lvMvList.ClientRectangle.Width);
        }
        //接受后端错误提示
        public void setPrompt(String news)
        {
            MessageBox.Show(news, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //}
        //重唱
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlEnd.setCmd(ExCmd.CMD_RESET);
        }
        //切歌
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ControlEnd.setCmd(ExCmd.CMD_NEXT);
        }

        private void 向上移动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ControlEnd.exMvList(ExCmd.CMD_UP);
        }

        private void 置顶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlEnd.exMvList(ExCmd.CMD_UPUP);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlEnd.exMvList(ExCmd.CMD_DELETE);
        }
        //排行
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmPai pai = new frmPai();
            pai.Show();
        }
        //分类
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmfeilei fl = new frmfeilei();
            fl.Show();
        }
        //播放
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "播放")
            {

                label1.Text = "暂停";
                ControlEnd.setCmd(ExCmd.CMD_PLAY);
            }
            else if (label1.Text == "暂停")
            {
                label1.Text = "播放";
                ControlEnd.setCmd(ExCmd.CMD_PAUSE);
            }
        }
        //切歌
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ControlEnd.setCmd(ExCmd.CMD_NEXT);
        }
        //已点
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (this.splitContainer1.Visible == true)
            {
                this.splitContainer1.Visible = false;
            }
            else
            {
                this.splitContainer1.Visible = true;
            }
        }
        //静音
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (this.label8.Text == "静音")
            {
                ControlEnd.exSound(true);
                this.label8.Text = "还原";
            }
            else
            {
                ControlEnd.exSound(false);
                this.label8.Text = "静音";
            }
        }
       //重唱
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ControlEnd.setCmd(ExCmd.CMD_RESET);
        }
        //音量滑块
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ControlEnd.exVolume();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //退出
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(10 * 10, 255, 255, 255);
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.label19.BackColor = Color.FromArgb(10 * 0, 255, 255, 255);
        }
        //酒水
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            frmjiu jiu = new frmjiu();
            jiu.Show();
        }
        //服务
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("如有任何需要,请拨打电话:13834377870", "温馨提示");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("如有任何需要,请拨打电话:13834377870", "温馨提示");
        }
    }
    }

