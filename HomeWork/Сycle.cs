using System;

namespace HomeWork
{
    public class Сycle
    {
        public static int printDegreeInputNumber(int a, int b)
        {
            //Пользователь вводит 2 числа(A и B).Возвести число A в степень B.
            Console.WriteLine("Введите первое целое число");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число");
            b = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static void printNumberDividedByInput()
        {
            //Пользователь вводит 1 число(A).Вывести все числа от 1 до 1000, которые делятся на A.
            Console.WriteLine("Введите целое положительное число");
            int A2 = Convert.ToInt32(Console.ReadLine());
            int B2 = 1000;

            for (int i = 0; i < B2; i++)
            {
                if (i % A2 == 0)
                    Console.WriteLine($"{i}");
            }
        }

        public static void printCountNumberSquareLessInput()
        {
            //Пользователь вводит 1 число(A).Найдите количество положительных целых чисел, 
            //квадрат которых меньше A.
            Console.WriteLine("Введите целое положительное число");
            int A3 = Convert.ToInt32(Console.ReadLine());
            int B3 = 1;

            while (B3 * B3 < A3)
            {
                Console.WriteLine($"{B3}");
                B3++;
            }
        }

        public static void printGreatestDivisor()
        {
            //Пользователь вводит 1 число(A).Вывести наибольший делитель(кроме самого A) 
            //числа A.
            Console.WriteLine("Введите целое положительное число");
            int A4 = Convert.ToInt32(Console.ReadLine());
            int B4 = 1;

            for (int i = 2; i < A4 / 2; i++)
            {
                if (A4 % i == 0)
                {
                    int result4 = A4 / i;
                    Console.WriteLine($" Число {result4} является наибольший делителем");
                    break;
                }
            }
        }

        public static void printSumInputNumbersDividedBySeven()
        {
            //Пользователь вводит 2 числа(A и B).Вывести сумму всех чисел из диапазона от A до B, 
            //которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
            Console.WriteLine("Введите первое целое число");
            int A5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число");
            int B5 = Convert.ToInt32(Console.ReadLine());

            int result5 = 0;
            if (A5 <= B5)
            {
                for (int i = A5; i < B5; i++)
                {
                    if (i % 7 == 0)
                    {
                        result5 += i;
                    }
                }
            }
            else
            {
                for (int i = B5; i < A5; i++)
                {
                    if (i % 7 == 0)
                    {
                        result5 += i;
                    }
                }
            }
            Console.WriteLine($"{result5} - сумма всех чисел из диапазона, которые делятся без остатка на 7");
        }

        public static void printInputNumberInFibonacciSeries()
        {
            //Пользователь вводит 1 число(N).Выведите N - ое число ряда фибоначчи.
            //В ряду фибоначчи каждое cледующее число является суммой двух предыдущих. 
            //Первое и второе считаются равными 1.
            Console.WriteLine("Введите целое положительное число");
            int A6 = Convert.ToInt32(Console.ReadLine());
            int fiboBig = 1;
            int fiboSmall = 1;
            int result6 = 0;

            for (int i = 0; i < A6; i++)
            {
                fiboSmall = fiboBig;
                fiboBig = result6;
                result6 = fiboSmall + fiboBig;
            }
            Console.WriteLine($"{result6}");
        }

        public static void findCommonDivisorByEvklid()
        {
            //Пользователь вводит 2 числа.Найти их наибольший общий делитель используя алгоритм Евклида.
            Console.WriteLine("Введите первое целое число");
            int A7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int B7 = Convert.ToInt32(Console.ReadLine());
            int result7 = 1;

            while (A7 != B7)
            {
                if (A7 < B7)
                {
                    B7 = B7 - A7;
                }
                else
                {
                    A7 = A7 - B7;
                }
            }
            Console.WriteLine($"{A7} - наибольший общий делитель");
        }

        public static void printPowThirdDegreeByHalfDivision()
        {
            //Пользователь вводит целое положительное число, которое является кубом целого числа N. 
            //Найдите число N методом половинного деления.
            Console.WriteLine("Введите целое положительное число");
            int A8 = Convert.ToInt32(Console.ReadLine());
            int Right = A8;
            int Left = 0;
            int N = (Left + Right) / 2;

            // первый вариант
            //while (Left * Left * Left != A8)
            //{
            //    if (Left * Left * Left <= Right)
            //    {
            //        Left = Left++;
            //    }
            //    else
            //    {
            //        Left = Left--;
            //        Console.WriteLine(Left);
            //        break;
            //    }
            //}

            // второй вариант
            while (N * N * N != A8)
            {
                if (N * N * N <= A8 &&
                    (N + 1) * (N + 1) * (N + 1) > A8)
                {
                    Console.WriteLine(N);
                    return;
                }
                else if (N * N * N < A8)
                {
                    Left = (Left + Right / 2) / 2;
                    N = (Left + Right) / 2;
                }
                else
                {
                    Right = (Left + Right) / 2;
                    N = (Left + Right) / 2;
                }
            }
        }

        public static void printCountOddNumber()
        {
            //Пользователь вводит 1 число.Найти количество нечетных цифр этого числа.
            Console.WriteLine("Введите целое положительное число");
            int A9 = Convert.ToInt32(Console.ReadLine());
            int result9 = 0;
            for (int i = 10; i < A9 * 10; i *= 10)
            {
                if ((A9 / i) % 2 != 0)
                {
                    result9++;
                }
            }
            Console.WriteLine($"{result9}");
        }

        public static void printNumberMirrorImage()
        {
            //Пользователь вводит 1 число.Найти число, которое является зеркальным отображением 
            //последовательности цифр заданного числа, например, задано число 123, вывести 321.
            Console.WriteLine("Введите целое положительное число");
            int A10 = Convert.ToInt32(Console.ReadLine());
            int result10 = 0;

            for (int i = 10; i < A10 * 10; i *= 10)
            {
                if (A10 % i < 10)
                {
                    result10 = A10 % i;
                }
                else
                {
                    result10 = result10 * 10 + (A10 % i) / (i / 10);
                    Console.WriteLine($"{result10}");
                }
            }
        }

        public static void printNumbersSumEvenMoreSumOdd()
        {
            //Пользователь вводит целое положительное  число(N).Выведите числа в диапазоне от 1 до N, 
            //сумма четных цифр которых больше суммы нечетных. 
            Console.WriteLine("Введите целое положительное число");
            int A11 = Convert.ToInt32(Console.ReadLine());
            int resultEven = 0;
            int resultOdd = 0;

            for (int i = 0; i < A11; i++)
            {
                if (i % 2 == 0)
                {
                    resultEven = resultEven + i;
                    if (resultEven > resultOdd)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
                else
                {
                    resultOdd = resultOdd + i;
                }
            }
        }

        public static void printAnswerIfSameNumber()
        {
            //Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры. 
            //Например, для пары 123 и 3456789, ответом будет являться “ДА”, 
            //а, для пары 500 и 99 - “НЕТ”.
            Console.WriteLine("Введите первое целое положительное число");
            int A12 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое положительное число");
            int B11 = Convert.ToInt32(Console.ReadLine());

            int resultA = 0;
            int resultB = 0;

            string yes = "ДА";
            string no = "НЕТ";

            for (int i = 10; i < A12 * 10; i *= 10)
            {
                resultA = (A12 % i) / (i / 10);
                for (int j = 10; j < B11 * 10; j *= 10)
                {
                    resultB = (B11 % j) / (j / 10);
                    if (resultA == resultB)
                    {
                        Console.WriteLine(yes);
                        return;
                    }
                }
                if (i > A12)
                {
                    Console.WriteLine(no);
                    return;
                }
            }
        }
    }
}
