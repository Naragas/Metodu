using System;

namespace Metoda2_CW8
{
    class Program
    {

        static void Move(int number, int from, int to, int free)
        {
            if (number > 0)
            {
                Move(number - 1, from, free, to);
                Console.WriteLine("{0} => {1}", from, to);
                Move(number - 1, free, from, to);

            }
        }

        static void Main(string[] args)
        {
            Move(4, 1, 2, 3);
            Console.ReadLine();
        }

    }
}
