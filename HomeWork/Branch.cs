using System;

namespace HomeWork
{
    class Branch
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа(A и B).Если A > B, подсчитать A+B, если A = B, подсчитать A* B, если A < B, подсчитать A-B.
            Console.WriteLine("Введите целое число А");
            int A1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число В");
            int B1 = Convert.ToInt32(Console.ReadLine());
            int result1 = 0;

            if (A1 > B1)
            {
                result1 = A1 + B1;
            }
            else if (A1 == B1)
            {
                result1 = A1 * B1;
            }
            else
            {
                result1 = A1 - B1;
            }
            //Пользователь вводит 2 числа(X и Y).Определить какой четверти принадлежит точка с координатами(X, Y).
            Console.WriteLine("Введите число X");
            double A2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число Y");
            double B2 = Convert.ToInt32(Console.ReadLine());

            if (A2 > 0)
            {
                if (B2 > 0)
                {
                    Console.WriteLine("Координата принадлежит к I четверти");
                }
                else if (B2 == 0)
                {
                    Console.WriteLine("Координата принадлежит к I, IV четвертям");
                }
                else
                {
                    Console.WriteLine("Координата принадлежит к IV четверти");
                }
            }
            else if (A2 == 0)
            {
                if (B2 > 0)
                {
                    Console.WriteLine("Координата принадлежит к I, II четвертям");
                }
                else if (B2 == 0)
                {
                    Console.WriteLine("Координата является 0");
                }
                else
                {
                    Console.WriteLine("Координата принадлежит к III, IV четвертям");
                }

            }
            else
            {
                if (B2 > 0)
                {
                    Console.WriteLine("Координата принадлежит кo II четверти");
                }
                else if (B2 == 0)
                {
                    Console.WriteLine("Координата принадлежит к II, III четвертям");
                }
                else
                {
                    Console.WriteLine("Координата принадлежит к III четверти");
                }
            }

            //Пользователь вводит 3 числа(A, B и С).Выведите их в консоль в порядке возрастания.
            Console.WriteLine("Введите число А");
            int A3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число B");
            int B3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число C");
            int C3 = Convert.ToInt32(Console.ReadLine());

            if (A3 > B3 || A3 > C3)
            {
                if (A3 > B3)
                {
                    if (B3 > C3)
                    {
                        Console.WriteLine($"{C3}, {B3}, {A3}");
                    }
                    else
                    {
                        Console.WriteLine($"{B3}, {C3}, {A3}");
                    }
                }
                else
                {
                    if (B3 > C3)
                    {
                        Console.WriteLine($"{C3}, {B3}, {A3}");
                    }
                    else
                    {
                        Console.WriteLine($"{B3}, {C3}, {A3}");
                    }

                }
            }
            else
            {
                if (B3 > C3)
                {
                    Console.WriteLine($"{A3}, {C3}, {B3}");

                }
                else
                {
                    Console.WriteLine($"{A3}, {B3}, {C3}");

                }
            }

            //Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2 + BX + C = 0.
            //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа.
            //                Например при вводе “25” в консоль будет выведено “двадцать пять”.

        }
    }
}
