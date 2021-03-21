using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class ArrayOneDimensional
    {
        //static void Main(string[] args)
        //{
        //    int[] array = createRandomArray();

        //    int arrayMin = findMinElement(array);

        //    int arrayMax = findMaxElement(array);

        //    findIndexMinElement(array, arrayMin);

        //    findIndexMaxElement(array, arrayMax);

        //    calcSumElementOddIndex(array);

        //    makeArrayRevers(array);

        //    caltOddElementsOfArray(array);

        //    swapHalfsArray(array);

        //    sortArrayAscendingByBubbleSort(array);

        //    sortArrayDescendingByInsert(array);
        //}

        public static int[] CreateRandomArray()
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
            return array;
        }

        public static int FindMinElement(int[] array)
        {
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
            return arrayMin;
        }

        public static int FindMaxElement(int[] array)
        {
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
            return arrayMax;
        }

        public static void FindIndexMinElement(int[] array, int arrayMin)
        {
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
        }

        public static void FindIndexMaxElement(int[] array, int arrayMax)
        {
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
        }

        public static void CalcSumElementOddIndex(int[] array)
        {
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
        }

        public static void MakeArrayRevers(int[] array)
        {
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
        }

        public static void CaltOddElementsOfArray(int[] array)
        {
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
        }

        public static void SwapHalfsArray(int[] array)
        {
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
        }

        public static void SortArrayAscendingByBubbleSort(int[] array)
        {
            //Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert)) 
            int[] arraySort = new int[array.Length];
            array.CopyTo(arraySort, 0);
            for (int i = 0; i < arraySort.Length; i++)
            {
                for (int j = i + 1; j < arraySort.Length; j++)
                {
                    if (arraySort[i] > arraySort[j])
                    {
                        int x = arraySort[i];
                        arraySort[i] = arraySort[j];
                        arraySort[j] = x;
                    }
                }
            }
            Console.Write("массив по возрастанию - ");
            for (int i = 0; i < arraySort.Length; i++)
            {
                Console.Write($"{arraySort[i]} ");
            }
            Console.WriteLine();
        }

        public static void SortArrayDescendingByInsert(int[] array)
        {
            //Отсортировать массив по убыванию одним из способов, (отличным от способа в 9 - м задании) :  
            //пузырьком(Bubble), выбором(Select) или вставками(Insert))
            int[] arraySortRevers = new int[array.Length];
            array.CopyTo(arraySortRevers, 0);
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && arraySortRevers[j - 1] < array[i])
                {
                    arraySortRevers[j] = arraySortRevers[j - 1];
                    j--;
                }
                arraySortRevers[j] = array[i];
            }
            Console.Write("массив по убыванию - ");
            for (int i = 0; i < arraySortRevers.Length; i++)
            {
                Console.Write($"{arraySortRevers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
