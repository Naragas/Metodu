using System;

namespace Metoda2_CW6
{
    class Program
    {
        static uint Factorial(uint n)
        {
            uint res = 1;
            for (uint i = 0; i <= n; i++)
                if (i == 0)
                    res = 1;
                else res *= i;
            return res;

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
