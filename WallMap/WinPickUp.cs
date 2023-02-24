using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class WinPickUp
    {
        public Player player;

        public bool PickUp = false;

        public WinPickUp(Player player)
        {
            this.player = player;
        }

        public void placePickUp(int y, int x)
        {
            if (player.win == false)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("W");

            }

            if (player.destX == x && player.destY == y)
            {
                player.win = true;
                Console.WriteLine("You Win!");
            }
        }
    }
}
