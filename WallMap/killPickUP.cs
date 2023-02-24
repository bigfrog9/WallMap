using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class killPickUp
    {

        public Player player;

        public Enemy enemy1;
        public Enemy enemy2;

        public Guard guard;

        public killPickUp(Player player, Enemy enemy1, Enemy enemy2, Guard guard)
        {
            this.player = player;
            this.enemy1 = enemy1;
            this.enemy2 = enemy2;
            this.guard = guard;
        }

        public bool PickUp = false;

        public bool Used = false;

        public void placePickUp(int y, int x)
        {
            if (Used == false)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("K");

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
