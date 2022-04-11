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
        private static List<string> soundNames = new List<string>()
        {
            "do.wav",
            "re.wav",
            "mi.wav",
            "fa.wav",
            "sol.wav",
            "la.wav",
            "si.wav"
        };

        private Piano.Scale scale;
        private PianoSoundPool pool;
        private MediaPlayer soundPlayer;
        private float lifespan;

        public Piano.Scale Scale
        {
            get { return scale; }
        }

        public PooledSoundPlayer(PianoSoundPool pool, Piano.Scale scale, float lifespan)
        {
            this.pool = pool;
            this.scale = scale;
            this.soundPlayer = new MediaPlayer();
            this.soundPlayer.Open(new Uri(System.AppDomain.CurrentDomain.BaseDirectory + "Sound/" + soundNames[(int)scale]));
            this.lifespan = lifespan;
        }

        public void Play()
        {
            soundPlayer.Stop();
            soundPlayer.Position = TimeSpan.Zero;
            soundPlayer.Play();
            Task.Delay((int)(lifespan * 1000)).ContinueWith(t =>
            {
                pool.ReturnToPool(this);
            });
        }
    }
}
