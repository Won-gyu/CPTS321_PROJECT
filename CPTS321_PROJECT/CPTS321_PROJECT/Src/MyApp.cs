using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT
{
    public class MyApp : SingletonBase<MyApp>
    {
        ScaleSoundPool pool;

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

        public MyApp()
        {
            pool = new ScaleSoundPool();
        }

        public void Play(Scale scale)
        {
            pool.GetAvailablePlayer(scale).Play();
        }
    }
}
