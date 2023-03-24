using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{

    internal class GameManager
    {
        static public bool gameOver = false;
        static public Map map = new Map();
        static public Enemy enemy1 = new Enemy(3, 3);
        static public Enemy enemy2 = new Enemy(15, 10);
        static public Player player = new Player();
        static public Guard guard = new Guard(20, 10, 6, 15, player);
        static public hPickUp potion = new hPickUp(player);
        static public killPickUp killPickUp = new killPickUp(player, enemy1, enemy2, guard);
        static public WinPickUp winPickUp = new WinPickUp(player);
        static public Boss boss = new Boss(30,100);

        static public bool arrested = false;

        public void RunGame()
        {
            Console.CursorVisible = false;
            enemy1.player = player;
            enemy2.player = player;

            while (gameOver == false)
            {
                player.Health = 3;

                player.x = 2;
                player.y = 14;

                enemy1.x = 2;
                enemy1.y = 2;

                enemy2.x = 15;
                enemy2.y = 10;

                enemy1.Kill = false;
                enemy2.Kill = false;

                player.Kill = false;
                arrested = false;

                while (player.win == false && player.Kill == false && arrested == false)
                {
                    map.DisplayMap();
                    player.destX = player.x;
                    player.destY = player.y;
                    enemy1.destX = enemy1.x;
                    enemy1.destY = enemy1.y;
                    enemy2.destX = enemy2.x;
                    enemy2.destY = enemy2.y;

                    if (player.isSpikes)
                    {
                        player.Health--;
                        Console.WriteLine("OUCHIE!!");
                        player.isSpikes = false;
                    }

                    if (enemy1.isPlayer)
                    {
                        Console.WriteLine("HIT!");
                    }

                    if (enemy2.isPlayer)
                    {
                        Console.WriteLine("HIT!");
                    }

                    Console.WriteLine("Health = " + player.Health);

                    if (enemy1.Kill)
                    {
                        Console.WriteLine("Zombie 1 was killed!");
                    }

                    if (enemy2.Kill)
                    {
                        Console.WriteLine("Zombie 2 was killed!");
                    }

                    if (guard.Kill)
                    {
                        Console.WriteLine("Guard was killed!");
                    }

                    potion.placePickUp(14, 6);
                    killPickUp.placePickUp(5, 47);
                    winPickUp.placePickUp(1, 1);

                    enemy1.Draw();
                    enemy2.Draw();
                    guard.Draw();

                    boss.Draw();

                    player.Draw();
                    player.Update();

                    if (player.destX == enemy1.x && player.destY == enemy1.y)
                    {
                        enemy1.Kill = true;
                        Console.WriteLine("Enemy 1 Killed!");
                    }

                    if (player.destX == enemy2.x && player.destY == enemy2.y)
                    {
                        enemy2.Kill = true;
                    }


                    enemy1.Update();
                    enemy1.Draw();
                    enemy2.Update();
                    enemy2.Draw();
                    guard.Update();
                    guard.Draw();
                    boss.BossAI();

                    if (player.Health <= 0)
                    {
                        player.Kill = true;
                    }

                    Console.Clear();
                }

                if (gameOver == false && player.win == true && player.Kill == false)
                {
                    Console.Clear();
                    Console.WriteLine("You Win!!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to end the game.");
                    Console.ReadKey(true);

                    gameOver = true;
                }

                if (player.win == false && player.Kill == true)
                {
                    Console.Clear();
                    Console.WriteLine("You lose!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey(true);
                    Console.Clear();
                    player.Kill = false;

                }

                if (player.win == false && arrested == true)
                {
                    Console.Clear();
                    Console.WriteLine("You were arrested!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey(true);
                    Console.Clear();
                    arrested = false;

                }
            }
        }
    }
}
