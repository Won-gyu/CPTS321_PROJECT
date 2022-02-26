using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CPTS321_PROJECT.Src
{
    public class PooledSoundPlayer
    {
        private MediaPlayer soundPlayer;
        private float lifespan;
        private bool isAvailable;
        public bool IsAvailable
        {
            get
            {
                return isAvailable;
            }
        }

        public PooledSoundPlayer(string path, float lifespan)
        {
            this.isAvailable = true;
            this.soundPlayer = new MediaPlayer();
            this.soundPlayer.Open(new Uri(path));
            this.lifespan = lifespan;
        }

        public void Play()
        {
            soundPlayer.Stop();
            soundPlayer.Position = TimeSpan.Zero;
            soundPlayer.Play();
            isAvailable = false;
            Task.Delay((int)(lifespan * 1000)).ContinueWith(t =>
            {
                isAvailable = true;
            });
        }
    }
}
