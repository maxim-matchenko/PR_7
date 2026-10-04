//****************************************************************************
//* Практическая работа N7                                                   *
//* Выполнил: Матченко M.C., группа 2-ИСП-оКФ                                *
//* Вариант 4                                                                *
//* Задание: Составление программ циклическкой структуры: цикл с параметром. *
//****************************************************************************
using System;
using System.ComponentModel;
namespace pr7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №7";
            double n, p, s;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine("Здравствуйте!");
            try
            {
                Console.Write("Введите стартовый капитал (n): ");
                n = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ежемесячный рост дохода в процентах (p): ");
                p = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите целевую сумму (s): ");
                s = Convert.ToDouble(Console.ReadLine());
                double Sum = 0;
                double d = n;
                int M = 0;
                int max = 10000; // верхняя граница цикла
                for (int m = 1; m <= max; m++) // цикл for
                {
                    Sum += d; // накопление  суммы
                    if (Sum >= s)
                    {
                        M = m;
                        break;// Досрочный выход из цикла
                    }
                    d = d * (1 + p / 100);
                }
                double year = (double)M / 12.0;
                Console.WriteLine($"Даня М. сможет отправиться в тур через {(Math.Round(year, 1))} лет.");
            }
            catch (Exception e) // обработка исключений (ошибок ввода текста вместо чисел)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nЧто-то пошло не так. Ошибка: " + e.Message);//  вывод на экран ошибки
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                //Console.ResetColor();// сброс цвета цвета текста и фона
            }
            Console.ReadKey();
        }
    }
}
