using System;

namespace Metoda2_CW1
{
    class Program
    {

        static int NOD(int a, int b)
        {
            while (a != b)
                if (a > b)
                    a = a - b;
                 else b = b - a;
            return a;

        }
        static void Main(string[] args)
        {
            int b = 532;
            int a = 224;
            Console.WriteLine(NOD(a, b));
            Console.ReadLine();


        }
    }
}
