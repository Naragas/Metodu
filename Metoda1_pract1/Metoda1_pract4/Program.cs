using System;

namespace Metoda1_pract4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int value = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Odd(value));
            Console.ReadLine();

        }

        static bool Odd(int n)
        {
            return n % 2 == 0;

        }

    }
}
