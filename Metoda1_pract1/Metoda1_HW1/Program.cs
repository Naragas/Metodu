using System;

namespace Metoda1_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше Имя");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу Фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост");
            double growth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Анкета сотрудника");
            Console.WriteLine("Имя: " + firstName + ", Фамилия: " + lastName + ", возраст: " + age + " лет , рост: " + growth + "см, вес: " + weight + "кг.");
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2} лет, Рост {3} см, Вес {4} кг.", firstName, lastName, age, growth, weight);
            Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}, Возраст: {age} лет, Рост {growth} см, Вес {weight} кг.");
            Console.ReadLine();

        }
    }
}
