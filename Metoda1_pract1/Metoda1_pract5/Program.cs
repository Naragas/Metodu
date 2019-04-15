using System;

namespace Metoda1_pract5
{
    class Program
    {

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);

        }
        static void Main(string[] args)
        {
            Print("Привет\n", 10, 10);
            Print("Привет еще раз", ConsoleColor.Red);
            Console.ReadLine();

            
        }
    }
}
