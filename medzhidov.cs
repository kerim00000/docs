using System;

namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анкета");  // Выводится надпись "Анкета"

            Console.Write("Имя: ");
            string name = Console.ReadLine(); // Программа считывает введенное имя 

            Console.Write("Фамилия: ");
            string surname = Console.ReadLine(); // Программа считывает введеную фамилию

            Console.Write("Возраст: ");
            string age = Console.ReadLine(); //  Программа считывает введенный возраст

            Console.Write("Рост: ");
            string height = Console.ReadLine(); // Программа считывает введенный рост

            Console.Write("Вес: ");
            string weight = Console.ReadLine(); // Программа считывает введенный вес

            Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight); // Выводятся данные анкеты используя склеивание
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, height, weight); // Выводятся данные анкеты используя формативный метод
            Console.WriteLine($"{name} {surname} {age} {height} {weight}"); // Выводятся данные анкеты используя вывод со знаком $ 
        }
    }
}

