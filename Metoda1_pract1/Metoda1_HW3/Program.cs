using System;

namespace Metoda1_HW3
{
    class Program
    {

        static double R(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            x1 = 2;
            x2 = 5;
            y1 = 3;
            y2 = 7;

            //double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:f2}",R(x1,x2,y1,y2));
            Console.ReadLine();




        }
    }
}
