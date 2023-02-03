using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class Program
    {
        static public Map map = new Map();
        static public Enemy enemy = new Enemy();
        static public Player player = new Player(enemy);

        static public bool gameOver = false;

        static void Main(string[] args)
        {
            enemy.player = player;


            while (gameOver == false && Player.win==false && enemy.win==false)
            {
                map.DisplayMap();

                enemy.Draw();

                player.Draw();
                player.Update();
                
                enemy.Update();
                enemy.Draw();

                Console.Clear();
            }

            while (gameOver == false && Player.win == true && enemy.win==false)
            {
                Console.Clear();
                Console.WriteLine("You Win!!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to end the game.");
                Console.ReadKey(true);

                gameOver = true;
            }

            while (gameOver==false&& Player.win==false && enemy.win == true)
            {
                Console.Clear();
                Console.WriteLine("You lose!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to try again.");
                Console.ReadKey(true);
                enemy.win = false;

            }
        }
    }
}
