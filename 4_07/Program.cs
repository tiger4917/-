System.Console.WriteLine("Введите число: ");
double num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение степени: ");
double n = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(num ,n);
System.Console.WriteLine($"Число {num}-> {result}");