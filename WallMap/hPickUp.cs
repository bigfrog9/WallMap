using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class hPickUp
    {
        public Player player;

        public bool PickUp = false;

        public bool Used = false;

        public hPickUp(Player player)
        {
            this.player = player;
        }

        public void placePickUp(int y, int x)
        {
            if (PickUp == false&&Used==false)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("H");

                if (player.destX == x && player.destY == y)
                {
                    PickUp = true;
                }
            }


            if (PickUp&&Used==false)
            {
                player.Health++;
                Used = true;

            }

        }
        
    }
}
