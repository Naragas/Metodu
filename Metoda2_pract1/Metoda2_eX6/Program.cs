using System;

namespace Metoda2_eX6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, count = 0;
            do
            {
                Console.Write("Input Age ");
                a = int.Parse(Console.ReadLine());
                count++;
            }
            while (a < 1 || a > 99);
            Console.WriteLine("You made " + count + " trys");
            Console.ReadLine();
        } 
        
    }
}
