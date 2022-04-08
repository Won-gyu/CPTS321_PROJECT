using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public interface IPianoObserver
    {
        void OnScalePlayed(Piano.Scale scale);
    }
}
