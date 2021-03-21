using System;

namespace HomeWork
{
    public class Сycle
    {
        public static int PrintDegreeInputNumber(int a, int b)
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

        public static void PrintNumberDividedByInput(int a)
        {
            //Пользователь вводит 1 число(A).Вывести все числа от 1 до 1000, которые делятся на A.
            Console.WriteLine("Введите целое положительное число");
            a = Convert.ToInt32(Console.ReadLine());
            int b = 1000;

            for (int i = 0; i < b; i++)
            {
                if (i % a == 0)
                    Console.WriteLine($"{i}");
            }
        }

        public static void PrintCountNumberSquareLessInput(int a)
        {
            //Пользователь вводит 1 число(A).Найдите количество положительных целых чисел, 
            //квадрат которых меньше A.
            Console.WriteLine("Введите целое положительное число");
            a = Convert.ToInt32(Console.ReadLine());
            int b = 1;

            while (b * b < a)
            {
                Console.WriteLine($"{b}");
                b++;
            }
        }

        public static void PrintGreatestDivisor(int a)
        {
            //Пользователь вводит 1 число(A).Вывести наибольший делитель(кроме самого A) 
            //числа A.
            Console.WriteLine("Введите целое положительное число");
            a = Convert.ToInt32(Console.ReadLine());
            int b = 1;

            for (int i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    int result = a / i;
                    Console.WriteLine($" Число {result} является наибольший делителем");
                    break;
                }
            }
        }

        public static int PrintSumInputNumbersDividedBySeven(int a, int b)
        {
            //Пользователь вводит 2 числа(A и B).Вывести сумму всех чисел из диапазона от A до B, 
            //которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
            Console.WriteLine("Введите первое целое число");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число");
            b = Convert.ToInt32(Console.ReadLine());

            int c = 7;
            int result = 0;
            if (a <= b)
            {
                for (int i = a; i < b; i++)
                {
                    if (i % c == 0)
                    {
                        result += i;
                    }
                }
            }
            else
            {
                for (int i = b; i < a; i++)
                {
                    if (i % c == 0)
                    {
                        result += i;
                    }
                }
            }
            Console.WriteLine($"{result} - сумма всех чисел из диапазона, которые делятся без остатка на 7");
            return result;
        }

        public static int PrintInputNumberInFibonacciSeries(int a)
        {
            //Пользователь вводит 1 число(N).Выведите N - ое число ряда фибоначчи.
            //В ряду фибоначчи каждое cледующее число является суммой двух предыдущих. 
            //Первое и второе считаются равными 1.
            Console.WriteLine("Введите целое положительное число");
            a = Convert.ToInt32(Console.ReadLine());
            int fiboBig = 1;
            int fiboSmall = 1;
            int result = 0;

            for (int i = 0; i < a; i++)
            {
                fiboSmall = fiboBig;
                fiboBig = result;
                result = fiboSmall + fiboBig;
            }
            Console.WriteLine($"{result}");
            return result;
        }

        public static void FindCommonDivisorByEvklid(int a, int b)
        {
            //Пользователь вводит 2 числа.Найти их наибольший общий делитель используя алгоритм Евклида.
            Console.WriteLine("Введите первое целое число");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число");
            b = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            while (a != b)
            {
                if (a < b)
                {
                    b = b - a;
                }
                else
                {
                    a = a - b;
                }
            }
            Console.WriteLine($"{a} - наибольший общий делитель");
        }

        public static int PrintPowThirdDegreeByHalfDivision(int a)
        {
            //Пользователь вводит целое положительное число, которое является кубом целого числа N. 
            //Найдите число N методом половинного деления.
            Console.WriteLine("Введите целое положительное число");
            a = Convert.ToInt32(Console.ReadLine());
            int Right = a;
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
            while (N * N * N != a)
            {
                if (N * N * N <= a &&
                    (N + 1) * (N + 1) * (N + 1) > a)
                {
                    Console.WriteLine(N);
                    return N;
                }
                else if (N * N * N < a)
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
            return N;
        }

        public static int PrintCountOddNumber(int a)
        {
            //Пользователь вводит 1 число.Найти количество нечетных цифр этого числа.
            Console.WriteLine("Введите целое положительное число");
            a = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 10; i < a * 10; i *= 10)
            {
                if ((a / i) % 2 != 0)
                {
                    result++;
                }
            }
            Console.WriteLine($"{result}");
            return result;
        }

        public static int PrintNumberMirrorImage(int a)
        {
            //Пользователь вводит 1 число.Найти число, которое является зеркальным отображением 
            //последовательности цифр заданного числа, например, задано число 123, вывести 321.
            Console.WriteLine("Введите целое положительное число");
            a = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 10; i < a * 10; i *= 10)
            {
                if (a % i < 10)
                {
                    result = a % i;
                }
                else
                {
                    result = result * 10 + (a % i) / (i / 10);
                    Console.WriteLine($"{result}");
                }
            }
            return result;
        }

        public static void PrintNumbersSumEvenMoreSumOdd(int a)
        {
            //Пользователь вводит целое положительное число(N).Выведите числа в диапазоне от 1 до N, 
            //сумма четных цифр которых больше суммы нечетных. 
            Console.WriteLine("Введите целое положительное число");
            a = Convert.ToInt32(Console.ReadLine());
            int resultEven = 0;
            int resultOdd = 0;

            for (int i = 0; i < a; i++)
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

        public static void PrintAnswerIfSameNumber(int a, int b)
        {
            //Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры. 
            //Например, для пары 123 и 3456789, ответом будет являться “ДА”, 
            //а, для пары 500 и 99 - “НЕТ”.
            Console.WriteLine("Введите первое целое положительное число");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое положительное число");
            b = Convert.ToInt32(Console.ReadLine());

            int resultA = 0;
            int resultB = 0;

            string yes = "ДА";
            string no = "НЕТ";

            for (int i = 10; i < a * 10; i *= 10)
            {
                resultA = (a % i) / (i / 10);
                for (int j = 10; j < b * 10; j *= 10)
                {
                    resultB = (b % j) / (j / 10);
                    if (resultA == resultB)
                    {
                        Console.WriteLine(yes);
                        return;
                    }
                }
                if (i > a)
                {
                    Console.WriteLine(no);
                    return;
                }
            }
        }
    }
}
