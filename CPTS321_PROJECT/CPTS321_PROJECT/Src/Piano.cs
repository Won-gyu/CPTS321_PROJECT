using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public sealed class Piano
    {
        private static Piano instance = null;
        private static readonly object padlock = new object();

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


        Piano()
        {
        }

        public static Piano Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Piano();
                    }
                    return instance;
                }
            }
        }

        public void Play(Scale scale)
        {
            NotifyPianoPlayed(scale);
        }

        // https://www.dofactory.com/net/observer-design-pattern
        private List<PianoObserver> observers = new List<PianoObserver>();
        public void Attach(PianoObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(PianoObserver observer)
        {
            observers.Remove(observer);
        }
        private void NotifyPianoPlayed(Scale scale)
        {
            foreach (PianoObserver o in observers)
            {
                o.NotifyPianoPlayed(scale);
            }
        }
    }
}
