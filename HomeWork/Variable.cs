using System;

namespace HomeWork
{
	public class Variable
    {
        public static int PrintSolving(ref int a, ref int b)
        {
            //Пользователь вводит 2 числа(A и B).Выведите в консоль решение (5 * A + B*B)/(B - A)

            Console.WriteLine("Введите первое целое число");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число");
            b = Convert.ToInt32(Console.ReadLine());

            int result = (5 * a + b * b) / (b - a);
            Console.WriteLine($"{result}");
            return result;
        }

        public static void ChangeVariable(ref int a, ref int b)
        {
            //Пользователь вводит 2 значения(A и B).Поменяйте содержимое переменных A и B местами.

            Console.WriteLine("Введите целое число A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число B");
            b = Convert.ToInt32(Console.ReadLine());

            int result2 = a;
            a = b;
            b = result2;
        }

        public static void PrintRemaiderOfDivision(int a, int b)
        {
            //Пользователь вводит 2 числа(A и B).Выведите в консоль результат деления A на B и остаток от деления.

            Console.WriteLine("Введите целое число A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число B");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"результат деления -{a / b}");
            Console.WriteLine($"остаток от деления - {a % b}");
        }

        public static int PrintSolvingLinearEquation(int a, int b, int c)
        {
            //Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X + B = C.

            Console.WriteLine("Введите целое число A");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                throw new Exception("Can't divide by zero!");
            }

            Console.WriteLine("Введите второе целое число B");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье целое число C");
            c = Convert.ToInt32(Console.ReadLine());

            int result = (c - b) / a;
            Console.WriteLine($"{result}");
            return result;
        }

        public static void PrintEquationLineOverTwoPoints()
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
