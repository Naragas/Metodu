using System;

namespace Metoda2_eX10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 80; i++)
            
                for (int j = 0; j < 24; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write('*');
                    System.Threading.Thread.Sleep(20);
                    Console.Title = "i=" + i + "j=" + j;
            }
            Console.ReadKey();
        }

    }
}
