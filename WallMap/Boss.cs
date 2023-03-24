﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class Boss
    {
        public int health = 5;

        public bool Kill = false;

        public int destX;
        public int destY;

        public int x;
        public int y;

        public bool isWall = false;

        public Player player;

        public bool isPlayer = false;

        //public bool moving=false;

        public Boss(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void BossAI()
        {
            destX = x;
            destY = y;


            Random random = new Random();

            
            //if (player.bossAggro == true)
            //{
              //  moving = true;
            //}

            if (Kill == false)
            {


                int move = random.Next(1, 4);

                if (move == 1)
                {
                    destY = destY - 1;
                }

                else if (move == 2)
                {
                    destY = destY + 1;
                }

                else if (move == 3)
                {
                    destX = destX - 1;
                }

                else if (move == 4)
                {
                    destX = destX + 1;
                }

                switch (GameManager.map.map[destX, destY])
                {
                    case ' ':
                        isWall = false;
                        break;

                    case 'o':
                        isWall = true;
                        break;
                        ;

                    case 'l':
                        isWall = true;
                        break;
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
                    player.Health = player.Health - 1;
                }

                if (isWall == false && isPlayer == false)
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
                    Console.Write("L");

                }
            }
    } 
}

