using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT.Src
{
    public class PianoSoundPool
    {
        List<List<PooledSoundPlayer>> soundPlayers;

        private static List<string> soundNames = new List<string>()
        {
            "do.wav",
            "re.wav",
            "mi.wav",
            "fa.wav",
            "sol.wav",
            "la.wav",
            "si.wav"
        };

        public PianoSoundPool(int initialPlayerCount = 1)
        {
            soundPlayers = new List<List<PooledSoundPlayer>>();

            int scaleCount = Enum.GetNames(typeof(Piano.Scale)).Length;
            for (int i = 0; i < scaleCount; i++)
            {
                soundPlayers.Add(new List<PooledSoundPlayer>());

                for (int j = 0; j < initialPlayerCount; j++)
                {
                    AddPooledObject((Piano.Scale)i);
                }
            }
        }

        public PooledSoundPlayer GetAvailablePlayer(Piano.Scale scale)
        {
            List<PooledSoundPlayer> players = soundPlayers[(int)scale];
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].IsAvailable)
                {
                    return players[i];
                }
            }
            return AddPooledObject(scale);
        }

        private PooledSoundPlayer AddPooledObject(Piano.Scale scale)
        {
            PooledSoundPlayer player = new PooledSoundPlayer(System.AppDomain.CurrentDomain.BaseDirectory + "Sound/" + soundNames[(int)scale], 1f);
            soundPlayers[(int)scale].Add(player);
            return player;
        }
    }
}
