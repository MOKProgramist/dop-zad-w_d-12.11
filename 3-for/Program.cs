using System;

namespace _3_for
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1, s = 0, n = 0, stop = 999; // переменные

            while (x != stop) // пока не будет введено значение
            {
                Console.Write("Введите число или {0}, чтобы завершить выполнение: ", stop);
                x = int.Parse(Console.ReadLine()); // считываем значение 
                if(x != stop)
                {
                    s += x; // сумма чисел
                    n++; // количество чисел
                }
            };

            Console.WriteLine("Количество чисел: {0} Сумма чисел: {1}", n, s);
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
