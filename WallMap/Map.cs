using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace WallMap
{
    internal class Map
    {
        public int x;
        public int y;



        public char[,] map = new char[129,16];


        //public char[,] map = new char[,]
        //{
        //    {'o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o'},
        //    {'o','~','~','~','~','~','~','o','~','~','~','~','~','~','~','~','~','~','~','o'},
        //    {'o','~','~','~','~','~','~','~','~','~','o','~','o','o','o','~','~','~','~','o'},
        //    {'o','~','~','o','o','~','~','~','~','~','o','~','o','~','~','~','~','o','~','o'},
        //    {'o','~','~','~','~','~','~','~','~','~','o','~','~','~','~','~','~','o','~','o'},
        //    {'o','~','~','~','o','o','o','~','~','~','o','~','~','~','~','~','~','o','~','o'},
        //    {'o','~','~','~','~','~','~','~','~','~','~','~','o','o','o','~','~','o','~','o'},
        //    {'o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o'},
        //};
        
        public void DisplayMap()
        {
           string[] mapString = File.ReadAllLines(@"Map.txt");

            //for (int i = 0; i < mapString.Length; i++)
            //{
            //    Console.WriteLine(mapString[i]);
            //}

            for (y = 0; y < mapString.Length; y++)
            {
                for (x= 0; x < mapString[y].Length; x++)
                {
                    map[x,y] = mapString[y][x];
                }
            }
            
            for (y = 0; y < 16; y++)
            {
                for (x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x,y]);
                }
                Console.WriteLine("");
            }


        }
    }
}
