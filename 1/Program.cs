using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)

        {

            {
                Console.WriteLine("Введите число A");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число B");
                int b = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine(5 * a + (b * b) / (b - a));
            }
        }
    }
}
