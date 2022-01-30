using SH_MusicPlayer.Lib.Files;
using System;
using System.Collections.Generic;
using System.Threading;
//using System.Windows.Forms;
using WMPLib;

namespace SH_MusicPlayer.Lib
{
    public class Player
    {
        public WindowsMediaPlayer player = new WindowsMediaPlayer();

        public List<string> playList;
        public int index = 0;

        public Timer _timer;

        public Player(string path)
        {
            player.settings.volume = 50;
            player.settings.autoStart = false;

            playList = Data.load(path);

            _timer = new Timer(new TimerCallback(Auto));
            _timer.Change(0, 300);

            player.URL = playList[index];
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

        public void Next()
        {
            index++;

            player.URL = playList[index];
        }

        public void Back()
        {
            index--;

            player.URL = playList[index];
        }

        private void Auto(object argse)
        {
            if (player.playState == WMPPlayState.wmppsStopped)
            {
                if(index == playList.Count)
                {
                    _timer.Change(Timeout.Infinite, Timeout.Infinite);
                }

                Next();
                Play();
            }
        }
    }
}
