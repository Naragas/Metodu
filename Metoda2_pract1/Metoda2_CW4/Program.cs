﻿using System;

namespace Metoda2_CW4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, s = 0;
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                if (a > 0 && a % 8 == 0)
                {
                    k++;
                    s = s + a;
                    a = int.Parse(Console.ReadLine());
                }
                else a = int.Parse(Console.ReadLine());


            }
            Console.WriteLine((double)s / k);
            Console.ReadLine();
        }
    }
}
