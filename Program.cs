using System;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double double_mr = 0;
            double last_cache = 0;

            while (true)
            {
                Console.Write("Выберете операцию (+, -, *, /, %, 1/x, x^2, x^0.5, m+, m-, mr): ");

                string action = Console.ReadLine();

                if (action == "m+")
                {
                    double_mr += last_cache;
                    Console.WriteLine("[Memory] Значение прибавилось.");

                    continue;
                }
                else if (action == "m-")
                {
                    double_mr -= last_cache;
                    Console.WriteLine("[Memory] Значение вычтено");

                    continue;
                }
                else if (action == "mr")
                {
                    Console.WriteLine($"[Memory] {double_mr}");

                    continue;
                }

                Console.WriteLine("Введите число!");
                double a = Convert.ToDouble(Console.ReadLine());

                switch (action)
                {
                    case "1/x":
                        last_cache = 1 / a;
                        Console.WriteLine(last_cache);
                        continue;
                    case "x^2":
                        last_cache = a * a;
                        Console.WriteLine(last_cache);
                        continue;
                    case "x^0.5":
                        last_cache = Math.Pow(a, 0.5);
                        Console.WriteLine(last_cache);
                        continue;
                }

                Console.WriteLine("\nВведите второе число!");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                switch (action)
                {
                    case "+":
                        last_cache = a + b;
                        Console.WriteLine(last_cache);
                        break;
                    case "-":
                        last_cache = a - b;
                        Console.WriteLine(last_cache);
                        break;
                    case "*":
                        last_cache = a * b;
                        Console.WriteLine(last_cache);
                        break;
                    case "/":
                        if (b == 0)
                        {
                            b = 1;
                            Console.WriteLine("На ноль делить нельзя. Вторая переменная заменена на 1");
                        }

                        last_cache = a / b;
                        Console.WriteLine(last_cache);
                        break;
                    case "%":
                        last_cache = a % b;
                        Console.WriteLine(last_cache);
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
