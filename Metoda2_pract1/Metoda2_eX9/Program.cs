using System;

namespace Metoda2_eX9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello, Foreach";
            foreach (char c in s)
                Console.Write("{0} ", c);

            Console.WriteLine();

            string s1 = "1. Привет, Foreach. \n2. А также break и continue! А это не выведется";
            foreach (char c1 in s1)
            {
                if (c1 >= '0' && c1 <= '9')
                    continue;
                if (c1 == '!')
                    break;
                Console.Write("{0}", c1);


            }
            Console.ReadLine();
        }
    }
}
