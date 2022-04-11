using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public class PianoSoundManager
    {
        PianoSoundPool pool;

        public PianoSoundManager()
        {
            PianoDispatcher.Instance.OnScalePlayed += OnScalePlayed;

            pool = new PianoSoundPool();
        }

        ~PianoSoundManager()
        {
            PianoDispatcher.Instance.OnScalePlayed -= OnScalePlayed;
        }

        private void OnScalePlayed(Piano.Scale scale)
        {
            pool.GetAvailablePlayer(scale).Play();
        }
    }
}
