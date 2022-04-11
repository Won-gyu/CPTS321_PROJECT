using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public class Piano : SingletonBase<Piano>
    {
        private PianoSoundManager pianoSoundManager;

        public enum Scale
        {
            Do,
            Re,
            Mi,
            Fa,
            Sol,
            La,
            Si
        }

        public Piano()
        {
            pianoSoundManager = new PianoSoundManager();
        }

        public void Play(Scale scale)
        {
            PianoDispatcher.Instance.DispatchEventScalePlayed(scale);
        }
    }
}
