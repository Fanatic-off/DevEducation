using System;

public class Variable
{
	public Variable()
	{
		static void Main(string[] args)
        {
			//Пользователь вводит 2 числа(A и B).Выведите в консоль решение (5 * A + B*B)/(B - A)
			//Console.WriteLine("Введите первое целое число");
			//int A = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("Введите второе целое число");
			//int B = Convert.ToInt32(Console.ReadLine());

			//int result = (5 * A + B * B) / (B - A);
			//Console.WriteLine($"{result}");

			//Пользователь вводит 2 значения(A и B).Поменяйте содержимое переменных A и B местами.
			Console.WriteLine("Введите целое число A");
			int A2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите второе целое число B");
			int B2 = Convert.ToInt32(Console.ReadLine());

			int result2 = A2;
			A2 = B2;
			B2 = A2;

			//Пользователь вводит 2 числа(A и B).Выведите в консоль результат деления A на B и остаток от деления.
			Console.WriteLine("Введите целое число A");
			int A3 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите второе целое число B");
			int B3 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"результат деления -{A3 / B3}");
			Console.WriteLine($"остаток от деления - {A3 % B3}");

			//Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A* X+B = C.
			Console.WriteLine("Введите целое число A");
			int A4 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите второе целое число B");
			int B4 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите третье целое число C");
			int C4 = Convert.ToInt32(Console.ReadLine());



			//Пользователь вводит 4 числа(X1, Y1, X2, Y2), описывающие координаты 2 - х точек на координатной плоскости.
			//	Выведите уравнение прямой в формате Y = AX + B, проходящей через эти точки.


		}
	}
}
