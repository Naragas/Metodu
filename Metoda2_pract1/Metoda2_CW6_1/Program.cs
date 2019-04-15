using System;

namespace Metoda2_CW6_1
{
    class Program
    {
        static uint Factorial(uint n)
        {
            if (n == 0) return 1;
            else return Factorial(n - 1) * n;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Factorial(n));
            Console.ReadLine();
        }
    }
}
