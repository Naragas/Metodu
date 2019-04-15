using System;

namespace Metoda2_HW4
{
    class Program
    {
        /*Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На
выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью
цикла do while ограничить ввод пароля тремя попытками.*/
        static bool LogIn(string s1, string s2)
        {
           string login = "root";
           string password = "GeekBrains";

            if (login.Equals(s1) && password.Equals(s2)) return true;
            return false;


        }
        static void Main(string[] args)
        {
            int k = 0;

            while (k != 3)
            {
                k++;
                Console.WriteLine("Введите логин");
                string s1 = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string s2 = Console.ReadLine();
                if (LogIn(s1, s2))
                {
                    Console.WriteLine("Доступ разрешен, попыток ввода данных: {0}", k);
                }
                else Console.WriteLine("Доступ запрещен. данные неверны.");
            }
            Console.ReadLine();
        }
    }
}
