using System;

namespace Metoda1_HW2
{
    class Program
    {
        static double IMT(double m, double h)
        {
            return m / (h * h);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу человека");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост челвоека");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Индекс массы тела человека равен : " + IMT(m, h));
            Console.ReadLine();

            
        }
    }
}
