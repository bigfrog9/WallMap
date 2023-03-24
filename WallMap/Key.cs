using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class Key
    {
        public Player player;

        public Enemy enemy1;
        public Enemy enemy2;

        public Guard guard;

        public Key(Player player)
        {
            this.player = player;
        }

        public bool PickUp = false;

        public bool Used = false;

        public void placePickUp(int y, int x)
        {
            if (Used == false)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("F");

                if (player.destX == x && player.destY == y)
                {
                    enemy1.Kill = true;
                    enemy2.Kill = true;
                    guard.Kill = true;

                    Used = true;
                }
            }

        }
    }
}
