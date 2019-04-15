using System;

namespace Metoda2_eX1
{
    class Program
    {

        static bool Odd(int x)
        {
            return x % 2 == 0;
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите целое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " - " + (Odd(x) ? "Четное число" : "Нечетное число"));

            Console.WriteLine("Для выхода нажмите Enter");
            Console.ReadLine();

        }
    }
}
