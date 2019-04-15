using System;

namespace Metoda1_HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 3;
            //int t = a;
            //a = b;
            //b = t;
            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
        }
    }
}
