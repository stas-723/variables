using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А: ");
            double A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число В: ");
            double B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число C: ");
            double C = Convert.ToInt32(Console.ReadLine());

            double x;

            {



                double X = (C - B) / A;


                Console.WriteLine($"A * X + B = C  X = {X}");

            }

        }
    }
}