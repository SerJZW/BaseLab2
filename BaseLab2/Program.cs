using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите a");
                Double a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("а не равно 0");
                    continue;
                }
                Console.WriteLine("Введите b");
                Double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите c");
                Double c = Convert.ToDouble(Console.ReadLine());
                Double D = b * b - 4 * a * c;

                if (D < 0)
                {
                    Console.WriteLine("нет решений");
                }
                else if (D == 0)
                    Console.WriteLine($"x = {-b / (2 * a)}");
                else if (D > 0)
                {
                    Console.WriteLine($"x1 = {-b + Math.Sqrt(D) / (2 * a)}");
                }
                else if (D > 0)
                {
                    Console.WriteLine($"x2 = {-b - Math.Sqrt(D) / (2 * a)}");
                }


            }
        }
    }
}