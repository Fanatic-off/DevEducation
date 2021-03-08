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

            //Пользователь вводит 3 числа(A, B и С).
            //Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2 + BX + C = 0.
            Console.WriteLine("Введите число А");
            double A4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число B");
            double B4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число C");
            double C4 = Convert.ToInt32(Console.ReadLine());
            double Discr = B4 * B4 - 4 * A4 * C4;

            if (Discr < 0)
            {
                Console.WriteLine("Корней не существует!");
            }
            else if (Discr == 0)
            {
                Console.WriteLine($"X1 = X2 = {-B4 / 2 * A4}");
            }
            else
            {
                double DiscrSqrt = Math.Sqrt(Discr);
                Console.WriteLine($"X1= {(-B4 + DiscrSqrt) / 2 * A4}; X2= {(-B4 - DiscrSqrt) / 2 * A4}");
            }

            //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа.
            //Например при вводе “25” в консоль будет выведено “двадцать пять”.
            Console.WriteLine("Введите двузначное число");
            int A5 = Convert.ToInt32(Console.ReadLine());

            //через switch
            switch (A5)
            {
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                case 4:
                    Console.WriteLine("четыре");
                    break;
                case 5:
                    Console.WriteLine("пять");
                    break;
                case 6:
                    Console.WriteLine("шесть");
                    break;
                case 7:
                    Console.WriteLine("семь");
                    break;
                case 8:
                    Console.WriteLine("восемь");
                    break;
                case 9:
                    Console.WriteLine("девять");
                    break;
                case 10:
                    Console.WriteLine("десять");
                    break;
                case 11:
                    Console.WriteLine("одиннадцать");
                    break;
            }
            //через if
            if (A5 < 10)
            {
                if (A5 == 1)
                {
                    Console.WriteLine("один");
                }
                else if (A5 == 2)
                {
                    Console.WriteLine("два");
                }
                else if (A5 == 3)
                {
                    Console.WriteLine("три");
                }
                else if (A5 == 4)
                {
                    Console.WriteLine("четыре");
                }
                else if (A5 == 5)
                {
                    Console.WriteLine("пять");
                }
                else if (A5 == 6)
                {
                    Console.WriteLine("шесть");
                }
                else if (A5 == 7)
                {
                    Console.WriteLine("семь");
                }
                else if (A5 == 8)
                {
                    Console.WriteLine("восемь");
                }
                else if (A5 == 9)
                {
                    Console.WriteLine("девять");
                }

            }
            else if (10 <= A5 && A5 < 20)
            {
                if (A5 % 10 == 0)
                {
                    Console.WriteLine("десять");
                }
                else if (A5 % 10 == 1)
                {
                    Console.WriteLine("одиннадцать");
                }
                else if (A5 % 10 == 2)
                {
                    Console.WriteLine("двенадцать");
                }
                else if (A5 % 10 == 3)
                {
                    Console.WriteLine("тринадцать");
                }
                else if (A5 % 10 == 4)
                {
                    Console.WriteLine("четырнадцать");
                }
                else if (A5 % 10 == 5)
                {
                    Console.WriteLine("пятьнадцать");
                }
                else if (A5 % 10 == 6)
                {
                    Console.WriteLine("шестьнадцать");
                }
                else if (A5 % 10 == 7)
                {
                    Console.WriteLine("семьнадцать");
                }
                else if (A5 % 10 == 8)
                {
                    Console.WriteLine("восемьнадцать");
                }
                else if (A5 % 10 == 9)
                {
                    Console.WriteLine("девятьнадцать");
                }
            }
            else if (20 <= A5 && A5 < 30)
            {

                Console.WriteLine("двадцать ");
                if (A5 % 10 == 1)
                {
                    Console.Write("один");
                }
                else if (A5 % 10 == 2)
                {
                    Console.Write("два");
                }
                else if (A5 % 10 == 3)
                {
                    Console.Write("три");
                }
                else if (A5 % 10 == 4)
                {
                    Console.Write("четыре");
                }
                else if (A5 % 10 == 5)
                {
                    Console.Write("пять");
                }
                else if (A5 % 10 == 6)
                {
                    Console.Write("шесть");
                }
                else if (A5 % 10 == 7)
                {
                    Console.Write("семь");
                }
                else if (A5 % 10 == 8)
                {
                    Console.Write("восемь");
                }
                else if (A5 % 10 == 9)
                {
                    Console.Write("девять");
                }

            }
            else if (30 <= A5 && A5 < 40)
            {
                Console.WriteLine("тридцать ");
                if (A5 % 10 == 1)
                {
                    Console.Write("один");
                }
                else if (A5 % 10 == 2)
                {
                    Console.Write("два");
                }
                else if (A5 % 10 == 3)
                {
                    Console.Write("три");
                }
                else if (A5 % 10 == 4)
                {
                    Console.Write("четыре");
                }
                else if (A5 % 10 == 5)
                {
                    Console.Write("пять");
                }
                else if (A5 % 10 == 6)
                {
                    Console.Write("шесть");
                }
                else if (A5 % 10 == 7)
                {
                    Console.Write("семь");
                }
                else if (A5 % 10 == 8)
                {
                    Console.Write("восемь");
                }
                else if (A5 % 10 == 9)
                {
                    Console.Write("девять");
                }
            }


        }
    }
}
