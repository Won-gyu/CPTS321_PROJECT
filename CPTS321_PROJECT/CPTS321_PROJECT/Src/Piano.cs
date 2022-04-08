using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public class Piano : SingletonBase<Piano>
    {
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
        }

        public void Play(Scale scale)
        {
            NotifyScalePlayed(scale);
        }

        private List<IPianoObserver> observers = new List<IPianoObserver>();
        public void Attach(IPianoObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(IPianoObserver observer)
        {
            observers.Remove(observer);
        }
        private void NotifyScalePlayed(Scale scale)
        {
            foreach (IPianoObserver o in observers)
            {
                o.OnScalePlayed(scale);
            }
        }
    }
}
