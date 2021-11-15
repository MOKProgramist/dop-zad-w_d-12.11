using System;

namespace _2_for
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1, n = 0, stop = 99; // переменные

            while (x != stop) // пока не будет введено значение
            {
                Console.Write("Введите число или {0}, чтобы завершить выполнение: ", stop);
                x = int.Parse(Console.ReadLine()); // считываем значение
                // Console.WriteLine(x > 0 ? "плюс" : "минус"); // проверяем на отрицательное значение
                n++; // количество чисел
            };

            Console.WriteLine("Количество чисел: {0}", n-1);
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
