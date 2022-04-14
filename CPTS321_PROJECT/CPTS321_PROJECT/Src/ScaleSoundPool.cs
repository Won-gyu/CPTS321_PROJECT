using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CPTS321_PROJECT
{
    public class ScaleSoundPool
    {
        List<Stack<PooledSoundPlayer>> soundPlayers;

        public ScaleSoundPool(int initialPlayerCount = 1)
        {
            soundPlayers = new List<Stack<PooledSoundPlayer>>();

            int scaleCount = Enum.GetNames(typeof(MyApp.Scale)).Length;
            for (int i = 0; i < scaleCount; i++)
            {
                soundPlayers.Add(new Stack<PooledSoundPlayer>());

                for (int j = 0; j < initialPlayerCount; j++)
                {
                    AddPooledObject((MyApp.Scale)i);
                }
            }
        }

        public PooledSoundPlayer GetAvailablePlayer(MyApp.Scale scale)
        {
            Stack<PooledSoundPlayer> players = soundPlayers[(int)scale];
            if (players.Count > 0)
            {
                return players.Pop();
            }
            else
            {
                return AddPooledObject(scale);
            }
        }

        public void ReturnToPool(PooledSoundPlayer player)
        {
            Stack<PooledSoundPlayer> players = soundPlayers[(int)player.Scale];
            players.Push(player);
        }

        private PooledSoundPlayer AddPooledObject(MyApp.Scale scale)
        {
            PooledSoundPlayer player = new PooledSoundPlayer(this, scale, 1f);
            soundPlayers[(int)scale].Push(player);
            return player;
        }
    }
}
