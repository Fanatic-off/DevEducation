using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class ArrayTwoDimensional
    {
        public static void Main(String[] args)
        {
            Random rnd = new Random();
            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int varRandom = rnd.Next(0, 99);
                    array[i, j] = varRandom;
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
