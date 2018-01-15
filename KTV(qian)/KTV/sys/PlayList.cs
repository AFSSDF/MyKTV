using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTV.sys
{
    class PlayList
    {
        public static Song[] SongList = new Song[50];
        public static int SongIndex = 0;
        //当前播放的歌曲名称
        static string name = "";
        public static string PlayingSongName()
        {

            if (SongList[SongIndex] != null)
            {
                name = SongList[SongIndex].SongName;
            }
            return name;
        }
        //获取当前播放的歌曲
        public static Song GetPlayingSong()
        {
            if (SongList[SongIndex] != null)
            {
                return SongList[SongIndex];
            }
            else
            {
                return null;
            }


        }
        //获取下一首要播放的歌曲名称
        public static string NextSongName()
        {

            if (SongList[SongIndex + 1] != null)
            {
                name = SongList[SongIndex + 1].SongName;
            }
            return name;
        }
        //点播一首歌曲
        public static bool AddSong(Song song)
        {
            bool success = false;
            for (int i = 0; i < SongList.Length; i++)
            {
                if (SongList[i] == null)
                {
                    SongList[i] = song;
                    success = true;
                    break;
                }
            }

            return success;
        }
        // 切歌
        public static void CutSong(int index)
        {
            int i;
            if (index == -1)
            {
                i = SongIndex;
            }
            else
            {
                i = index;
            }

            if (SongList[i] == null)
            {
                return;
            }
            SongList[i].SetSongCut();
            while (SongList[i] != null)
            {
                SongList[i] = SongList[i + 1];
                i++;
                if (i == SongList.Length)
                {
                    SongList[i] = null;
                }
            }
        }
        //重放当前播放的歌曲
        public static void PlayAgain()
        {
            if (SongList[SongIndex] != null)
            {
                SongList[SongIndex].SetPlayAgain();
            }

        }
        //播放下一首歌曲
        public static void MoveOn()
        {
            if (SongList[SongIndex] != null && SongList[SongIndex].PlayState == SongPlayState.again)
            {
                SongList[SongIndex].SetSongPlayed();
            }
            else
            {
                SongIndex++;
            }
        }
    }
}
