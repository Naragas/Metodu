using System;

namespace Metada1_pract6
{
    class Program
    {

        static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;
        }

        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ведите число А");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите число А");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите число А");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Может существовать треугольник с такими сторонами : " + IsTriangle(a, b, c));
            Console.WriteLine("Площадь треугольника: " + S(a, b, c));
            Console.ReadLine();

        }
    }
}
