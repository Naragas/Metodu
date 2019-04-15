using System;

namespace Metoda2_HW1
{
    class Program
    {
        /*1. Написать метод, возвращающий минимальное из трёх чисел.*/
        static int MinFrom3(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c) return a;
                else return c;
            }
            else
            {
                if (b < c) return b;
                else return c;
            }
        }
        /*2. Написать метод подсчета количества цифр числа.*/
        static int DigitCount(int n)
        {
            int k = 0;
            while (n != 0)
            {
                n = n / 10;
                k++;
            }
            return k;
        }
        static void Main(string[] args)
        {
           
            Console.ReadLine();

           

        }
    }
}
