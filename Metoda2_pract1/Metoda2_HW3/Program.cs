using System;

namespace Metoda2_HW3
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int s = 0;
            Console.WriteLine("Enter number, Enter (0) to stop");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                if (n % 2 != 0) s = s + n; 
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
