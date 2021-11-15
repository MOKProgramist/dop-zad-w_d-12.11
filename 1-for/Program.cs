using System;

namespace _1_for
{
    class Program
    {
        static void Main(string[] args)
        {
            double x; // переменные

            do
            {
                Console.Write("Введите число или 0, чтобы завершить выполнение: ");
                x = int.Parse(Console.ReadLine()); // считываем значение
                Console.WriteLine(x > 0 ? "плюс" : "минус"); // проверяем на отрицательное значение
            } while (x != 0); // пока не будет введено значение

            Console.WriteLine("Ты завершил выполнение");
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
