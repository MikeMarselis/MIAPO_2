using ConsoleApp1.Models;

bool point = true;
while (point)
{
	Console.Write("Введите первое число: ");
	float a = float.Parse(Console.ReadLine());
	Console.Write("\nВведите второе число: ");
	float b = float.Parse(Console.ReadLine());
	Console.WriteLine("Выберите действие: +, -, *, /, %");
	string action = Console.ReadLine();
	switch (action)
	{
		case "+":
			Console.Clear();
			Console.WriteLine($"Сумма чисел {a} и {b} = {Addition.Sum(a,b)}");
			break;
		case "-":
            Console.Clear();
            Console.WriteLine($"Разность чисел {a} и {b} = {Substraction.Sub(a,b)}");
			break; 
		case "*":
            Console.Clear();
            Console.WriteLine($"Произведение чисел {a} и {b} = {Multiplication.Mult(a,b)}");
			break;
		case "/":
            Console.Clear();
            Console.WriteLine($"Частное числа {a} и {b} = {Division.Div(a,b)}");
			break;
		case "%":
            Console.Clear();
            Console.WriteLine($"Процент {b} от числа {a} = {Percent.PercentOfNum(a,Convert.ToInt32(b))}");
			break;
	}
    Console.WriteLine("Продолжить? Y/N");
	string action2 = Console.ReadLine();
	if (action2.ToLower() == "n")
	{
		point = false;
	}
}