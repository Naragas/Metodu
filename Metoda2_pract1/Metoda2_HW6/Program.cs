using System;

namespace Metoda2_HW6
{
    /*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000
000. «Хорошим» называется число, которое делится на сумму своих цифр . Реализовать
подсчёт времени выполнения программы, используя структуру DateTime.*/
    class Program
    {

        static bool isGood (int n)
        {
            int digitSumm = 0;
            int number = n;
            while (n != 0)
            {
                digitSumm = digitSumm + (n % 10);
                n = n / 10;
            }
            return number % digitSumm == 0 ? true : false;

        }
        static void Main(string[] args)
        {

            DateTime start = DateTime.Now;
            int k = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                if (isGood(i)) k++;
            }
            Console.WriteLine(k);
            Console.WriteLine("Затрачено времение на решение задачи" + (DateTime.Now - start));
            Console.ReadLine();
        }
    }
}
