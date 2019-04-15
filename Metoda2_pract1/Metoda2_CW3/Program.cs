using System;

namespace Metoda2_CW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите ваш возраст от 1 до 50");
            x = int.Parse(Console.ReadLine());
            string s = "Вам " + x;
            if (x % 10 == 1 && x != 11)
                s += " год";
            else if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 && x <= 34) || (x > 41 && x < 45))
                s += " года";
            else if ((x==11) || (x>=5 && x<=20) || (x>=25 &&x<=30) ||(x>=35 && x<=40)||(x>44 && x<51))
                s += " лет";

            Console.WriteLine(s);
            Console.ReadLine();


        }
    }
}
