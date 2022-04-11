using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public class PianoDispatcher : SingletonBase<PianoDispatcher>
    {
        public event Action<Piano.Scale> OnScalePlayed;

        public void DispatchEventScalePlayed(Piano.Scale scale)
        {
            OnScalePlayed?.Invoke(scale);
        }
    }
}
