using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public class PianoSoundManager : SingletonBase<PianoSoundManager>, IPianoObserver
    {
        PianoSoundPool pool;

        public PianoSoundManager()
        {
            pool = new PianoSoundPool();
        }

        public void OnScalePlayed(Piano.Scale scale)
        {
            pool.PlayScale(scale);
        }
    }
}
