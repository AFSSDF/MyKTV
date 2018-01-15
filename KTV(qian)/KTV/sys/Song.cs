using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTV.sys
{
    public enum SongPlayState
    {
        //未播放，播放，重播，切歌
        unplayed, played, again, cut
    }
    class Song
    {
        //歌曲名称字段
        private string songName;
        public string SongName
        {
            get { return songName; }
            set { songName = value; }
        }
        //歌曲存放路径字段
        private string songURL;
        public string SongURL
        {
            get { return songURL; }
            set { songURL = value; }
        }
        //歌曲播放状态字段
        private SongPlayState playState = SongPlayState.unplayed;
        internal SongPlayState PlayState
        {
            get { return playState; }
            set { playState = value; }
        }

        public void SetSongPlayed()
        {
            this.playState = SongPlayState.played;
        }

        //将歌曲状态改为在播放一次
        public void SetPlayAgain()
        {
            this.playState = SongPlayState.again;
        }

        //将歌曲状态改为切歌
        public void SetSongCut()
        {
            this.playState = SongPlayState.cut;
        }
    }
}
