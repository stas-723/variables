using System;

namespace _3


{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число В: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int x; int x1;

            {


                x = A / B;
                x1 = A % B;



                Console.WriteLine($"результат деления:{x}");
                Console.WriteLine($"остаток:{x1}");
            }

        }
    }
}
