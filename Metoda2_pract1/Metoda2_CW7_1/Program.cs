using System;

namespace Metoda2_CW7_1
{
    class Program
    {

        static uint Fib(uint n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return (Fib(n - 1) + Fib(n - 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Fib(n));
            Console.ReadLine();
        }
    }
}
