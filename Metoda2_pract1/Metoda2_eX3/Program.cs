﻿using System;

namespace Metoda2_eX3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            String s;
            switch (m)
                {
                case 1:
                case 2:
                case 12: s = "Winter";
                    break;
                case 3:
                case 4:
                case 5: s = "Spring";
                    break;
                case 6:
                case 7:
                case 8: s = "Summer";
                    break;
                case 9:
                case 10:
                case 11: s = "Autumn";
                    break;
                default: s = "Нет такого месяца";
                    break;
                    


            }
            Console.WriteLine(s);

            Console.ReadLine();
           
        }
    }
}
