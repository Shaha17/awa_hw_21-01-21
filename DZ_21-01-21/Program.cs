using System;

namespace DZ_21_01_21
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Задание № 1.2");
			// Задание 1.2
			// Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить
			// каждой переменной большее из этих значений, а если равны, то присвоить переменным
			// нулевые значения. Вывести новые значения переменных A и B.
			int A, B;
			Console.WriteLine("Введите целое число A:");
			int.TryParse(Console.ReadLine(), out A);
			Console.WriteLine("Введите целое число B:");
			int.TryParse(Console.ReadLine(), out B);

			A = B = (A == B) ? 0 : Math.Max(A, B);

			Console.WriteLine($"A = {A}\nB = {B}");
			Console.WriteLine();

			Console.WriteLine("Задание № 1.3");
			// Задание 1.3
			// Напишите программу - консольный калькулятор. Создайте две переменные с именами
			// operand1 и operand2. Задайте переменным некоторые произвольные значения.
			// Предложите пользователю ввести знак арифметической операции. Примите значение,
			// введенное пользователем, и поместите его в строковую переменную sign. Для
			// организации выбора алгоритма вычислительного процесса, используйте переключатель
			// switch. Выведите на экран результат выполнения арифметической операции. В случае
			// использования операции деления, организуйте проверку попытки деления на ноль. И
			// если таковая имеется, то отмените выполнение арифметической операции и уведомите
			// об ошибке пользователя.
			double operand1, operand2;
			string sign;

			Console.WriteLine("Введите первое число:");
			double.TryParse(Console.ReadLine(), out operand1);
			Console.WriteLine("Введите второе число:");
			double.TryParse(Console.ReadLine(), out operand2);
			Console.WriteLine("Введите операцию над этими числами:");
			sign = Console.ReadLine();
			double? rez = null;
			switch (sign)
			{
				case "+":
					rez = operand1 + operand2;
					break;
				case "-":
					rez = operand1 - operand2;
					break;
				case "*":
					rez = operand1 * operand2;
					break;
				case "/":
					if (operand2 != 0)
					{
						rez = operand1 / operand2;
					}
					else
					{
						Console.WriteLine("Ошибка деления на 0");
					}
					break;
				default:
					Console.WriteLine("Введена недопустимая операция");
					break;
			}
			if (rez.HasValue)
			{
				Console.WriteLine($"Результат операции \"{sign}\" равен ${rez}");
			}
			Console.WriteLine();

			Console.WriteLine("Задание № 1.4");
			// Задание 1.4
			// Напишите программу определения, попадает ли указанное пользователем число от 0 до
			// 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50] [51 - 100]. Если да, то укажите, в
			// какой именно промежуток. Если пользователь указывает число, не входящее ни в один
			// из имеющихся числовых промежутков, то выводится соответствующее сообщение.
			double n;
			Console.WriteLine("Введите число для определния промежутка:");
			double.TryParse(Console.ReadLine(), out n);
			if (n >= 0 && n <= 14)
			{
				Console.WriteLine("Число находится в промежутке [0 - 14]");
			}
			else if (n >= 15 && n <= 35)
			{
				Console.WriteLine("Число находится в промежутке [15 - 35]");
			}
			else if (n >= 36 && n <= 50)
			{
				Console.WriteLine("Число находится в промежутке [36 - 50]");
			}
			else if (n >= 51 && n <= 100)
			{
				Console.WriteLine("Число находится в промежутке [51 - 100]");
			}
			else
			{
				Console.WriteLine("Число не находится ни в одном из допустимых промежутков");
			}
			Console.WriteLine();

			Console.WriteLine("Задание № 2.2");
			// Задание 2.2
			// Написать программу вычисления стоимости покупки с учетом скидки. Скидка в 3%
			// предоставляется в том случае, если сумма покупки больше 500 сомони, в 5% - если
			// сумма больше 1000 сомони
			double price, discountedPrice;
			Console.WriteLine("Введите цену, чтобы узнать стоитмость покупки с учётом скидки:");
			double.TryParse(Console.ReadLine(), out price);
			discountedPrice = price switch
			{
				> 1000 => price * 0.95,
				> 500 => price * 0.97,
				_ => price
			};
			Console.WriteLine($"Цена с учётом скидок равна {discountedPrice}");
			Console.WriteLine();

			Console.WriteLine("Задание № 2.3");
			// Задание 2.3
			// Даны четыре числа. Если они не образуют возрастающую последовательность,
			// вывести минимальный из них; если числа равны, найти их произведение, иначе
			// сообщение «Числа расположены по возрастанию».
			System.Console.WriteLine("Введите четыре числа последовательности");
			double curr, prev, minimum, product = 1;
			bool isIncreasing = true, isEqual = true;

			double.TryParse(Console.ReadLine(), out curr);
			minimum = curr;
			product *= curr;
			for (int i = 0; i < 3; i++)
			{
				prev = curr;
				double.TryParse(Console.ReadLine(), out curr);
				minimum = Math.Min(minimum, curr);
				product *= curr;
				if (!(prev > curr && isIncreasing))
					isIncreasing = false;
				if (!(prev == curr && isEqual))
					isEqual = false;
			}
			if (isIncreasing)
			{
				Console.WriteLine($"Последовательность возрастающая\nМинимальное число равно {minimum}");
			}
			else if (isIncreasing)
			{
				Console.WriteLine($"Числа последовательности равны\nПроизведение этих чисел равно {product}");
			}
			else
			{
				Console.WriteLine("Числа расположена по возрастанию");
			}
			Console.WriteLine();

			Console.WriteLine("Задание № 2.4");
			// Задание 2.4
			// Запрашиваются три числа для переменных a, b, c. Значения переменных поменять
			// таким образом, чтобы a >= b >= c.
			double a, b, c;
			Console.WriteLine("Введите первое число:");
			double.TryParse(Console.ReadLine(), out a);
			Console.WriteLine("Введите второе число:");
			double.TryParse(Console.ReadLine(), out b);
			Console.WriteLine("Введите третье число:");
			double.TryParse(Console.ReadLine(), out c);
			double max, min, mid;
			max = Math.Max(a, Math.Max(b, c));
			min = Math.Min(a, Math.Min(b, c));
			mid = a + b + c - max - min;
			a = max;
			b = mid;
			c = min;
			Console.WriteLine($"Изменённые значения переменных {a} >= {b} >= {c}");
			Console.WriteLine();
		}
	}
}
