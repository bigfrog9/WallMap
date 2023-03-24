using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class Program
    {

        static public GameManager gameManager=new GameManager();

        static void Main(string[] args)
        {
            gameManager.RunGame();
        }
    }
}
