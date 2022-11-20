using System;

namespace _4._76
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Первое число: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(a) > Math.Abs(b)) a /= 2;
            Console.WriteLine("Итог {0} ", a);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
