using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class ArrayOneDimensional
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                int varRandom = rnd.Next(0, 99);
                array[i] = varRandom;
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            //Найти минимальный элемент массива
            int arrayMin = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < arrayMin)
                {
                    arrayMin = array[i];
                }
            }
            Console.WriteLine($"минимальный элемент массива - {arrayMin}");

            //Найти максимальный элемент массива
            int arrayMax = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > arrayMax)
                {
                    arrayMax = array[i];
                }
            }
            Console.WriteLine($"максимальный элемент массива - {arrayMax}");

            //Найти индекс минимального элемента массива
            int arrayMinIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= arrayMin)
                {
                    arrayMinIndex = i;
                }
            }
            Console.WriteLine($"индекс минимального элемента массива - {arrayMinIndex}");

            //Найти индекс максимального элемента массива
            int arrayMaxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= arrayMax)
                {
                    arrayMaxIndex = i;
                }
            }
            Console.WriteLine($"индекс максимального элемента массива - {arrayMaxIndex}");

            //Посчитать сумму элементов массива с нечетными индексами
            int arraySum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    arraySum += array[i];
                }
            }
            Console.WriteLine($"суммa элементов массива с нечетными индексами - {arraySum}");

            //Сделать реверс массива(массив в обратном направлении)
            int[] arrayRevers = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayRevers[array.Length - i - 1] = array[i];

            }
            Console.Write("реверс массива(массив в обратном направлении) - ");
            for (int i = 0; i < arrayRevers.Length; i++)
            {
                Console.Write($"{arrayRevers[i]} ");
            }
            Console.WriteLine();

            //Посчитать количество нечетных элементов массива
            int oddNumberArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddNumberArray++;
                }
            }
            Console.WriteLine($"количество нечетных элементов массива - {oddNumberArray}");

            //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
            int[] arrayBackToForward = new int[array.Length];
            if (array.Length % 2 != 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    arrayBackToForward[array.Length / 2 + i + 1] = array[i];
                }
            }
            else
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    arrayBackToForward[array.Length / 2 + i] = array[i];
                }
            }
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                arrayBackToForward[i - array.Length / 2] = array[i];
            }
            Console.Write("поменяли местами первую и вторую половину массива - ");
            for (int i = 0; i < arrayBackToForward.Length; i++)
            {
                Console.Write($"{arrayBackToForward[i]} ");
            }
            Console.WriteLine();

            //Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert)) 
            //Отсортировать массив по убыванию одним из способов, (отличным от способа в 9 - м задании) :  
            //                пузырьком(Bubble), выбором(Select) или вставками(Insert))

        }
    }
}
