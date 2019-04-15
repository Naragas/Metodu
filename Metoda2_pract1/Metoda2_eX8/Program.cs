using System;

namespace Metoda2_eX8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            int max = a > b ? a : b;
            int min = a < b ? a : b;
            int k = 0, s = 0;
            for (int i = max; i >= min; i--)
            {
                Console.Write(i + " ");
                k++;
                s=s+i;
            }
            Console.WriteLine("\nk={0} s={1}", k,s);
            Console.ReadLine();
            
        }
    }
}
