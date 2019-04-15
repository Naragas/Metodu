using System;

namespace Metoda1_pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 1;
            double c = 1;
            double x;
            Console.WriteLine("Введите значение Х");
            x = Convert.ToDouble(Console.ReadLine());
            double result = a * Math.Pow(x, 2) + b * x + c;
            Console.WriteLine("{0}*x^2 + {1}*x + {2} = {3} , при х = {4}", a, b, c, result, x);
            Console.ReadLine();

        }
    }
}
