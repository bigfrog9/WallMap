using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallMap
{
    internal class Map
    {
        public int x;
        public int y;


        public char[,] map = new char[,]
        {
            {'o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o'},
            {'o','~','~','~','~','~','~','o','~','~','~','~','~','~','~','~','~','~','~','o'},
            {'o','~','~','~','~','~','~','~','~','~','o','~','o','o','o','~','~','~','~','o'},
            {'o','~','~','o','o','~','~','~','~','~','o','~','o','~','~','~','~','o','~','o'},
            {'o','~','~','~','~','~','~','~','~','~','o','~','~','~','~','~','~','o','~','o'},
            {'o','~','~','~','o','o','o','~','~','~','o','~','~','~','~','~','~','o','~','o'},
            {'o','~','~','~','~','~','~','~','~','~','~','~','o','o','o','~','~','o','~','o'},
            {'o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o'},
        };
        
        public void DisplayMap()
        {
            for (y = 0; y < 8; y++)
            {
                for (x = 0; x < 20; x++)
                {
                    Console.Write(map[y,x]);
                }
                Console.WriteLine("");
            }
        }
    }
}
