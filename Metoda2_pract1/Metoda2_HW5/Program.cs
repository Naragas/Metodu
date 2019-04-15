using System;

namespace Metoda2_HW5
{
    /*а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой вес в килограммах.");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой рост в метрах.");
            double growth = Convert.ToDouble(Console.ReadLine());

            BodyMassIndex(weight, growth);
            


            Console.ReadLine();
        }

        static void BodyMassIndex(double a, double b)
        {
            double IMT = a / (b * b);
            if (IMT < 22)
            {
                Console.WriteLine("Нужно покушать");
                Console.WriteLine("Нужно набрать еще " + ((22 * b * b) - a) + " килограмма");
            }
            else if (IMT > 25)
            {
                Console.WriteLine("Хватит есть, займись спортом.");
                Console.WriteLine("Нужно сбросить еще " + (a - (25 * b * b)) + " килограмма");
            }
            else Console.WriteLine("Вес в норме");
        }

    }
}
