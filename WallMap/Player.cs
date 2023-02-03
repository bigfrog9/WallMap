using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class Player
    {
        static ConsoleKeyInfo input;
        public int destX;
        public int destY;

        public static bool win = false;

        public int x = 2;
        public int y = 2;

        public bool isWall = false;

        public Enemy enemy;
        static public Program program = new Program();

        public Player(Enemy enemy)
        {
            this.enemy = enemy;
        }
        public void Update()
        {
            destX = x;
            destY = y;

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

            switch (Program.map.map[destY, destX])
            {
                case '~': isWall = false;
                    break;

                case 'o': isWall = true;
                    break;
            }

            if (isWall == false)
            {
                x = destX;
                y = destY;
            }

            if (x == enemy.x && y == enemy.y)
            {
                win = true;
            }
        }


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("#");
        }
    }
}
