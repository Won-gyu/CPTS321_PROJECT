using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public class SingletonBase<T>
    {
        private static SingletonBase<T> instance = null;
        private static readonly object padlock = new object();

        public SingletonBase()
        {
        }

        public static SingletonBase<T> Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonBase<T>();
                    }
                    return instance;
                }
            }
        }
    }
}
