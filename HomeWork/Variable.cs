using System;

namespace HomeWork
{
	class Variable
    {

        private static void PrintSolving()
        {
            //Пользователь вводит 2 числа(A и B).Выведите в консоль решение (5 * A + B*B)/(B - A)

            Console.WriteLine("Введите первое целое число");
            int A1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число");
            int B1 = Convert.ToInt32(Console.ReadLine());

            int result = (5 * A1 + B1 * B1) / (B1 - A1);
            Console.WriteLine($"{result}");
        }

        private static void ChangeVariable()
        {
            //Пользователь вводит 2 значения(A и B).Поменяйте содержимое переменных A и B местами.

            Console.WriteLine("Введите целое число A");
            int A2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число B");
            int B2 = Convert.ToInt32(Console.ReadLine());

            int result2 = A2;
            A2 = B2;
            B2 = A2;
        }

        private static void PrintRemaiderOfDivision()
        {
            //Пользователь вводит 2 числа(A и B).Выведите в консоль результат деления A на B и остаток от деления.

            Console.WriteLine("Введите целое число A");
            int A3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число B");
            int B3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"результат деления -{A3 / B3}");
            Console.WriteLine($"остаток от деления - {A3 % B3}");
        }

        private static void PrintSolvingLinearEquation()
        {
            //Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X + B = C.

            Console.WriteLine("Введите целое число A");
            int A4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число B");
            int B4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье целое число C");
            int C4 = Convert.ToInt32(Console.ReadLine());

            int result4 = (C4 - B4) / A4;
            Console.WriteLine($"{result4}");
        }

        private static void PrintEquationLineOverTwoPoints()
        {         
            //Пользователь вводит 4 числа(X1, Y1, X2, Y2), описывающие координаты 2 - х точек на координатной плоскости.
            //	Выведите уравнение прямой в формате Y = AX + B, проходящей через эти точки.
            Console.WriteLine("Введите координату X1");
            double X1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату Y1");
            double Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату X2");
            double X2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату Y2");
            double Y2 = Convert.ToInt32(Console.ReadLine());

            //A = (y1 - y2) / (x1 - x2)
            //B = y2 - A*x2
            Console.WriteLine($"уравнение имеет вид: Y = {(Y1 - Y2) / (X1 - X2)}X + {Y2 - ((Y1 - Y2) / (X1 - X2)) * X2}");
        }
    }
}
