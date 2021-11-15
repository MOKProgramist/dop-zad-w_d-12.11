using System;

namespace _5_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, s = 0, n = 0; // переменные

            Console.Write("Введите число: ");
            x = int.Parse(Console.ReadLine()); // считываем значение 
            s = (int) Math.Pow(x, 2); // число в квадрате

            while (x != s) // пока не будет достигнуто значение
            {
                x += 1; 
                Console.Write(x + ", "); 
            };

            Console.WriteLine("Конец :)");
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
