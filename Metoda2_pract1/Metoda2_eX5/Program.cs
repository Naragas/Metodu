using System;

namespace Metoda2_eX5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while(n !=0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
