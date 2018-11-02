using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaciLaci.Backend
{
    public class Engine
    {
        const int numberOfLines = 10;
        Map map = new Map();
        string[,] MapCells = new string[10, 10];
        string[] WhatObjectIsHere = new string[10];

        /*Reads the .txt file for the map layout by splitting each of line string in the .txt
         *the letters inside the .txt can be of 5 different types
         * N for Nothing
         * T for Tree
         * B for Basket
         * H for Hunter
         * and L for Laszlo the Bear
         * after each line is read the indentifier are copied into the MapCell matrix for map generation
        */
        public void ReadMap(string filepath)
        {
            string Line;
            StreamReader File = new StreamReader(filepath);
            for (int i = 0; i < numberOfLines; i++)
            {
                Line = File.ReadLine();
                for (int j = 0; j < numberOfLines; j++)
                {
                    WhatObjectIsHere = Line.Split(';');
                    MapCells[i, j] = WhatObjectIsHere[j];
                }
            }
            File.Close();
        }

        //Copies the MapCell matrix into the given parameter matrix so the UI can load the map that has been read last time
        public void GetMapElements(string[,] Matrix)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfLines; j++)
                {
                    Matrix[i, j] = MapCells[i,j];
                }
            }
        }
    }
}
