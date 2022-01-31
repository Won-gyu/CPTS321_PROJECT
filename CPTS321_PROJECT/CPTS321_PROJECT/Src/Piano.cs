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
            
        }



        //private List<Observer> observers = new List<Observer>();
        //public void Attach(Observer observer)
        //{
        //    observers.Add(observer);
        //}
        //public void Detach(Observer observer)
        //{
        //    observers.Remove(observer);
        //}
        //public void Notify()
        //{
        //    foreach (Observer o in observers)
        //    {
        //        o.Update();
        //    }
        //}
    }
}
