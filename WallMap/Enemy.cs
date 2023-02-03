using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class Enemy
    {
        public int destX;
        public int destY;

        public int x = 16;
        public int y = 5;

        public bool isWall = false;

        public bool win = false;

        public Player player;

        public void Update()
        {
            destX = x;
            destY = y;

            Random random = new Random();

            int move = random.Next(1,4);

            if (move == 1)
            {
                destY = destY - 1;
            }

            else if (move==2)
            {
                destY = destY + 1;
            }

            else if (move==3)
            {
                destX = destX - 1;
            }

            else if (move==4)
            {
                destX = destX + 1;
            }

            switch (Program.map.map[destY, destX])
            {
                case '~':
                    isWall = false;
                    break;

                case 'o':
                    isWall = true;
                    break;
            }

            if (isWall == false)
            {
                x = destX;
                y = destY;
            }

            if (x==player.x && y == player.y)
            {
                win = true;
            }

        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("E");
        }
    }
}
