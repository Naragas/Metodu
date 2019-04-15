using System;

namespace Metoda2_CW7
{
    class Program
    {


        static uint Fib(uint n)
        {
            uint a0 = 0;
            uint a1 = 1;
            uint a = a1;

            for (int i = 2; i <= n; i++)
            {
                a = a0 + a1;
                a0 = a1;
                a1 = a;

            }
            return a1;
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
