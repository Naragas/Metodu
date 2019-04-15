using System;

namespace Metoda2_HW7
{
    class Program
    {

        static void RecurMetod(int a, int b)
        {
            if (a <= b)
            {

                Console.Write(a + " ");
                a++;
                RecurMetod(a, b);
            }

        }

        static int RecursSumm(int a, int b)
        {
            return (a == b) ? b : a + RecursSumm(a + 1, b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            RecurMetod(a, b);
            Console.WriteLine("Сумма чисел: " + RecursSumm(a, b));
            Console.ReadLine();

        }
    }
}
