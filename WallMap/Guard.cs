using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class Guard
    {
        public int destX;
        public int destY;

        public int x;
        public int y;

        public int maxX;
        public int minX;

        public Guard(int maxX, int minX, int y, int x, Player player)
        {
            this.maxX = maxX;
            this.minX = minX;
            this.y = y;
            this.x = x;
            this.player = player;
        }

        public bool isWall = false;

        public Player player;

        public bool isPlayer = false;

        public bool Kill = false;

        public bool goingRight = true;

        public bool goingLeft = false;

        public void Update()
        {
            

            if (Kill == false)
            {
                destX = x;
                destY = y;
                //int move = random.Next(1, 4);

                if (goingRight)
                {
                    destX++;
                }

                if (goingRight==false)
                {
                    destX--;
                }

                if (destX >= maxX)
                {
                    goingRight = false;
                }

                if (destX <= minX)
                {
                    goingRight = true;
                }

                if (destX == player.x && destY == player.y)
                {
                    isPlayer = true;
                }

                else
                {
                    isPlayer = false;
                }

                if (isPlayer)
                {
                    GameManager.arrested = true;
                }
                
                if (isWall==false&&isPlayer == false)
                {
                    x = destX;
                    y = destY;
                }
            }

        }

        public void Draw()
        {
            if (Kill == false)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("G");

            }
        }
    }
}
