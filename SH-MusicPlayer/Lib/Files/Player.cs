using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using WMPLib;

namespace SH_MusicPlayer.Lib.Files
{
    public class Player
    {
        public WindowsMediaPlayer player;

        public List<string> playList;

        public Player(string path)
        {
            player = new WindowsMediaPlayer();
            player.settings.autoStart = false;
            player.settings.volume = 50;

            playList = Data.load(path);
        }

        public void SetMusic(string path)
        {
            player.URL = @path;
        }

        public void Play()
        {
            player.controls.play();
        }

        public void Pause()
        {
            player.controls.pause();
        }

        public void Volume(int volume)
        {
            player.settings.volume = volume;
        }


    }
}
