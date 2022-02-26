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
            NotifyPianoPlayed(scale);
        }

        // https://www.dofactory.com/net/observer-design-pattern
        private List<IPianoObserver> observers = new List<IPianoObserver>();
        public void Attach(IPianoObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(IPianoObserver observer)
        {
            observers.Remove(observer);
        }
        private void NotifyPianoPlayed(Scale scale)
        {
            foreach (IPianoObserver o in observers)
            {
                o.NotifyPianoPlayed(scale);
            }
        }
    }
}
