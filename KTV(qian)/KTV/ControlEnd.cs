using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using KTV.sys;
using System.Windows.Forms;
using WMPLib;
using System.Data.SqlClient;

namespace KTV
{
    public class ControlEnd
    {

        static DBHelper dbHelper = new DBHelper();
        private static string mainPath;

        private static void Load_MainPath()
        {
            try
            {
                dbHelper.OpenConn();
                mainPath=new SqlCommand("SELECT resoure_path FROM resoure_path WHERE resoure_type='main'", dbHelper.Conn).ExecuteScalar().ToString() +"\\";
            }
            catch (Exception ex)
            {
                test.setPrompt(ex.ToString());
            }
            finally
            {
                dbHelper.CloseConn();
            }
        }

        public static List<MvInfo> mvList = new List<MvInfo>();
        public static List<MvInfo> finishMvList = new List<MvInfo>();
        //修改test
        static frmPlay frmplay = new frmPlay();
        static frmzhuye test = new frmzhuye();

        public static string MainPath
        {
            get
            {
                return mainPath;
            }
        }

        public ControlEnd()
        {
            test.Show();
            frmplay.Show();
            frmplay.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_PlayStateChange);
            frmplay.axWindowsMediaPlayer.settings.volume = 50;
            Load_MainPath();
        }
        //当前播放完毕后自动播放下一个
        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (frmplay.axWindowsMediaPlayer.playState == WMPPlayState.wmppsPaused)
            {
                return;
            }
            if (!(frmplay.axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded))
            {
                try { frmplay.axWindowsMediaPlayer.Ctlcontrols.play(); } catch { }
            }
            else
            {
                ControlEnd.setCmd(ExCmd.CMD_NEXT);
            }
        }

        //对前台Mv进行操作
        public static void setCmd(int cmd)
        {
            switch (cmd)
            {
                case ExCmd.CMD_PLAY:
                    if (frmplay.axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused || frmplay.axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        frmplay.axWindowsMediaPlayer.Ctlcontrols.play();
                    }
                    else
                    {
                        frmplay.axWindowsMediaPlayer.Ctlcontrols.play();
                        if (mvList.Count > 0)
                        {
                            frmplay.axWindowsMediaPlayer.URL = mvList[0].mv_path;
                            frmplay.axWindowsMediaPlayer.Ctlcontrols.play();
                            frmplay.lblNowMvName.Text = mvList[0].song_name + "-" + mvList[0].singer_name;
                            if (mvList.Count > 1)
                            {
                                frmplay.lblNextMvName.Text = mvList[1].song_name + "-" + mvList[1].singer_name;
                            }
                            else
                            {
                                frmplay.lblNextMvName.Text = "无下一首";
                            }
                        }
                    }
                    break;
                case ExCmd.CMD_PAUSE:
                    frmplay.axWindowsMediaPlayer.Ctlcontrols.pause();
                    break;
                case ExCmd.CMD_RESET:
                    if (mvList.Count > 0)
                    {
                        frmplay.axWindowsMediaPlayer.URL = mvList[0].mv_path;
                        frmplay.axWindowsMediaPlayer.Ctlcontrols.stop();
                        frmplay.axWindowsMediaPlayer.Ctlcontrols.play();
                    }
                    break;
                case ExCmd.CMD_NEXT:
                    if (mvList.Count > 0)
                    {
                        mvList.RemoveAt(0);
                    }
                    if (mvList.Count > 0)
                    {
                        frmplay.axWindowsMediaPlayer.URL = mvList[0].mv_path;
                        frmplay.axWindowsMediaPlayer.Ctlcontrols.play();
                        frmplay.lblNowMvName.Text = mvList[0].song_name + "-" + mvList[0].singer_name;
                        if (mvList.Count > 1)
                        {
                            frmplay.lblNextMvName.Text = mvList[1].song_name + "-" + mvList[1].singer_name;
                        }
                        else
                        {
                            frmplay.lblNextMvName.Text = "无下一首";
                        }
                    }
                    else
                    {
                        frmplay.axWindowsMediaPlayer.URL = "";
                        frmplay.lblNowMvName.Text = "无歌曲";
                        frmplay.lblNextMvName.Text = "无下一首";
                    }
                    break;
            }
            reMvList();
        }


        //静音或还原
        public static void exSound(bool i)
        {
            frmplay.axWindowsMediaPlayer.settings.mute = i;
        }

        //添加歌曲
        public static void addMvInfo(MvInfo addonce)
        {
            foreach (MvInfo once in mvList)
            {
                if (once.mv_path.Equals(addonce.mv_path))
                {
                    test.setPrompt("列表中已存在重复的歌曲");
                    return;
                }
            }
            ControlEnd.mvList.Add(addonce);
            //ControlEnd.addFinishMvListItem(addonce);
            ControlEnd.reMvList();
        }

        //添加至点歌记录并刷新
        //public static void addFinishMvListItem(MvInfo mvInfo)
        //{
        //    finishMvList.Add(mvInfo);
        //    int i = 0;
        //    test.lvFinishMvList.Items.Clear();
        //    foreach (MvInfo once in finishMvList)
        //    {
        //        i++;
        //        test.lvFinishMvList.Items.Add(new ListViewItem(new string[] { once.song_name, once.singer_name, once.mv_path, i.ToString() }));
        //    }
        //}

        //操作Mv菜单
        public static void exMvList(int cmd)
        {
            switch (cmd)
            {
                case ExCmd.CMD_DELETE:
                    mvList.Remove(getExMvInfo());
                    break;
                case ExCmd.CMD_UP:
                    if (int.Parse(test.lvMvList.SelectedItems[0].SubItems[3].Text) < 3)
                    {
                        test.setPrompt("已经不能再往上了");
                        break;
                    }
                    MvInfo upMvInfo = getExMvInfo();
                    mvList.Remove(upMvInfo);
                    mvList.Insert(int.Parse(test.lvMvList.SelectedItems[0].SubItems[3].Text) - 2, upMvInfo);
                    break;
                case ExCmd.CMD_UPUP:
                    if (int.Parse(test.lvMvList.SelectedItems[0].SubItems[3].Text) < 3)
                    {
                        test.setPrompt("已经不能再往上了");
                        break;
                    }
                    MvInfo upupMvInfo = getExMvInfo();
                    mvList.Remove(upupMvInfo);
                    mvList.Insert(1, upupMvInfo);
                    break;
            }
            reMvList();
            setCmd(ExCmd.CMD_PLAY);
        }

        //获得要操作的MvInfo
        private static MvInfo getExMvInfo()
        {
            MvInfo exMvInfo = null;
            foreach (MvInfo once in mvList)
            {
                if (test.lvMvList.SelectedItems[0].SubItems[2].Text.Equals(once.mv_path))
                {
                    exMvInfo = once;
                    break;
                }
            }
            return exMvInfo;
        }

        //刷新Mv菜单
        public static void reMvList()
        {
            int i = 0;
            test.lvMvList.Items.Clear();
            foreach (MvInfo once in mvList)
            {
                i++;
                test.lvMvList.Items.Add(new ListViewItem(new string[] { once.song_name, once.singer_name, once.mv_path, i.ToString() }));
            }
            if (mvList.Count > 0)
            {
                test.lblNoMv.Text = mvList[0].song_name;
                frmplay.lblNowMvName.Text = mvList[0].song_name;
                if(mvList.Count > 1)
                {
                    test.lblNextMv.Text = mvList[1].song_name;
                    frmplay.lblNextMvName.Text = mvList[1].song_name;
                }
                else
                {
                    test.lblNextMv.Text = "无歌曲";
                    frmplay.lblNextMvName.Text = "无歌曲";
                }
            }
            else
            {
                test.lblNoMv.Text = "无歌曲";
                frmplay.lblNowMvName.Text = "无歌曲";
                test.lblNextMv.Text = "无歌曲";
                frmplay.lblNextMvName.Text = "无歌曲";
            }
        }

        //滑动设置音量
        public static void exVolume()
        {
            frmplay.axWindowsMediaPlayer.settings.volume = test.trackBar1.Value;
        }
    }
}
