using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public class PooledSoundPlayer
    {
        private SoundPlayer soundPlayer;
        private float lifespan;
        private bool isAvailable;
        public bool IsAvailable
        {
            get
            {
                return isAvailable;
            }
        }

        public PooledSoundPlayer(string name, float lifespan)
        {
            this.soundPlayer = new SoundPlayer(name);
            this.lifespan = lifespan;
        }

        public void Play()
        {
            soundPlayer.Play();
            isAvailable = false;
            Task.Delay((int)(lifespan * 1000)).ContinueWith(t => { isAvailable = true; });
        }
    }
}
