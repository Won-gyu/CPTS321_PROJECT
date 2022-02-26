using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public abstract class PianoObserver
    {
        public abstract void NotifyPianoPlayed(Piano.Scale scale);
    }
}
