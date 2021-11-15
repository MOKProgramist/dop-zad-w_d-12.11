using System;

namespace _4_for
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1, s = 0, n = 0, stop = 100; // переменные

            while (s < stop) // пока не будет введено значение
            {
                Console.Write("Введите число: " );
                x = int.Parse(Console.ReadLine()); // считываем значение 

                s += x; //  сумма
                n++; // количество
            };

            Console.WriteLine("Количество чисел: {0} Сумма чисел: {1}", n, s);
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
