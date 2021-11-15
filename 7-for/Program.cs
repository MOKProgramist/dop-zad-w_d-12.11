using System;

namespace _7_for
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, s = 0; // переменные

            while (s != 7) // пока значение не равно 7
            {
                Console.Write("Введите дввузначное число: ");
                a = int.Parse(Console.ReadLine()); // считываем значение 

                if (a >= 10 && a <= 99)
                {
                    b = a % 10; // первая цифра
                    c = Math.Round(a / 10); // получаем последнюю цифру 
                    s = b + c; 
                }
                else
                {
                    Console.WriteLine("это не двузначное число");
                }
            }

            Console.WriteLine("Завершено");
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
