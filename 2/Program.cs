using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите число A");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число B");
            int b = Convert.ToInt32(Console.ReadLine());
            int tmp;

            tmp = a;
            a = b;
            b = tmp;



            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }
    }
}
