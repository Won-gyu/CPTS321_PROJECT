﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public class PianoSoundManager : IPianoObserver
    {
        PianoSoundPool pool;

        private PianoSoundManager()
        {
            pool = new PianoSoundPool();
        }

        public void NotifyPianoPlayed(Piano.Scale scale)
        {
            pool.PlayScale(scale);
        }
    }
}