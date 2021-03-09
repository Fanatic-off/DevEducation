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
            //Найти минимальный элемент массива
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            Console.WriteLine($" минимальный элемент массива - {min}");

            //Найти максимальный элемент массива
            //Найти индекс минимального элемента массива
            //Найти индекс максимального элемента массива
            //Найти количество элементов массива, которые больше всех своих соседей одновременно
            //Отразите массив относительно его главной диагонали


        }

    }
}
