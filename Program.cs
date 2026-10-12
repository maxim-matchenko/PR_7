//****************************************************************************
//* Практическая работа N7                                                   *
//* Выполнил: Матченко M.C., группа 2-ИСП-оКФ                                *
//* Вариант 4                                                                *
//* Задание: Составление программ циклической структуры: цикл с параметром.  *
//****************************************************************************
using System;
namespace PR_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №7"; // Заголовок консоли
            double initialCapital, monthlyGrowthPercent, targetAmount; // Объявление переменных (вещественные)
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear(); // Очистка консоли
            Console.WriteLine("Здравствуйте!");
            try
            {
                Console.Write("Введите стартовый капитал: ");
                initialCapital = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ежемесячный рост дохода в процентах : ");
                monthlyGrowthPercent = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите целевую сумму: ");
                targetAmount = Convert.ToDouble(Console.ReadLine());
                if (initialCapital <= 0 || monthlyGrowthPercent <= 0 || targetAmount <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    throw new ArgumentException("Введенные значения должны быть больше нуля!");
                }
                if (targetAmount <= initialCapital)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    throw new ArgumentException("Целевая сумма должна быть больше стартового капитала!");
                }
                double Sum = 0;
                double currentIncome = initialCapital;
                int totalMonth = 0;
                int maxMonth = 10000;
                for (int month = 1; month <= maxMonth; month++)
                {
                    Sum += currentIncome;
                    if (Sum >= targetAmount)
                    {
                        totalMonth = month;
                        break; // Досрочный выход из цикла при достижении цели
                    }
                    currentIncome *= 1 + monthlyGrowthPercent / 100;
                }
                double year = totalMonth / 12.0;
                Console.WriteLine($"\nДаня М. сможет отправиться в тур через {(Math.Round(year, 1))} лет.");
            }
            catch (Exception e) // обработка исключений (ошибок ввода текста вместо чисел)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nЧто-то пошло не так. Ошибка: " + e.Message);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ReadKey();
            }
        }
    }
}
