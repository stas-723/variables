using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты X1");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты X2");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int a = (y1 - y2) / (x1 - x2);
            int b = y2 - a * x2;

            Console.WriteLine($"y = {a}x + {b}");
        }
    }
}