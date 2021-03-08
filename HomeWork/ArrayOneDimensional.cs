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
            //Найти индекс минимального элемента массива
            //Найти индекс максимального элемента массива
            //Посчитать сумму элементов массива с нечетными индексами
            //Сделать реверс массива(массив в обратном направлении)
            //Посчитать количество нечетных элементов массива
            //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
            //Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert)) 
            //Отсортировать массив по убыванию одним из способов, (отличным от способа в 9 - м задании) :  
            //                пузырьком(Bubble), выбором(Select) или вставками(Insert))

        }
    }
}
