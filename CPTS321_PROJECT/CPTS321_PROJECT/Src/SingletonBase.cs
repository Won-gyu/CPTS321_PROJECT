using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public abstract class SingletonBase<T> where T : class, new()
    {
        private static T instance = null;
        private static readonly object padlock = new object();

        public SingletonBase()
        {
        }

        public static T Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new T();
                    }
                    return instance;
                }
            }
        }
    }
}
