using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class Player
    {
        public int Health = 3;

        public bool Kill;

        static ConsoleKeyInfo input;
        public int destX;
        public int destY;

        public bool win = false;

        public int x = 2;
        public int y = 14;

        public bool isWall = false;

        public bool isSpikes = false;

        public bool bossAggro=false;

        public void Update()
        {
            destX = x;
            destY = y;

            

            if (Health == 0)
            {
                Kill = true;
            }

            input = Console.ReadKey(true);

            if (input.KeyChar == 'w')
            {
                destY = destY - 1;
            }

            else if (input.KeyChar == 's')
            {
                destY = destY + 1;
            }

            else if (input.KeyChar == 'a')
            {
                destX = destX - 1;
            }

            else if (input.KeyChar == 'd')
            {
                destX = destX + 1;
            }

            switch (GameManager.map.map[destX, destY])
            {
                case ' ': isWall = false;
                    break;

                case 'o': isWall = true;
                    break;

                case 'x': isSpikes = true;
                    isWall = true;
                    break;

                case 'l': bossAggro = true;
                    isWall = false;
                    break;

            }

            if (isWall == false)
            {
                x = destX;
                y = destY;
            }

            //if (x == enemy.x && y == enemy.y)
            //{
             //   win = true;
            //}
        }


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("#");
        }
    }
}
