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
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            Console.WriteLine($" минимальный элемент массива - {max}");

            //Найти индекс минимального элемента массива
            int minIndexI = 0;
            int minIndexJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] <= min)
                    {
                        minIndexI = i;
                        minIndexJ = j;
                    }
                }
            }
            Console.WriteLine($"индекс минимального элемента массива - {minIndexI},{minIndexJ} ");

            //Найти индекс максимального элемента массива
            int maxIndexI = 0;
            int maxIndexJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] >= max)
                    {
                        maxIndexI = i;
                        maxIndexJ = j;
                    }
                }
            }
            Console.WriteLine($"индекс максимального элемента массива - {maxIndexI},{maxIndexJ}");

            //Найти количество элементов массива, которые больше всех своих соседей одновременно
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i <= 0 || array[i, j] > array[i - 1, j])
                        && (i >= array.GetLength(0) - 1 || array[i, j] > array[i + 1, j])
                        && (j <= 0 || array[i, j] > array[i, j - 1])
                        && (j >= array.GetLength(1) - 1 || array[i, j] > array[i, j + 1]))
                    {
                        count++;
                        Console.WriteLine($"{array[i, j]} i = {i} j = {j}");
                    }
                }
            }
            Console.WriteLine($"количество элементов массива, которые больше всех своих соседей одновременно - {count}");

            //Отразите массив относительно его главной диагонали


        }

    }
}
