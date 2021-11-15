using System;

namespace _6_for
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b = 0, s; // переменные

            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine()); // считываем значение 

            while (a != b) // пока не будет введено последней переменной
            {
                b = a; // присваеваем новое значение после ввода
                Console.Write("Введите число: ");
                a = int.Parse(Console.ReadLine()); // считываем значение 
            };

            Console.WriteLine("Сумма чисел: {0}", a * 2);
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
