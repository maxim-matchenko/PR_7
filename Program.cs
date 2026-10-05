//****************************************************************************
//* Практическая работа N7                                                   *
//* Выполнил: Матченко M.C., группа 2-ИСП-оКФ                                *
//* Вариант 4                                                                *
//* Задание: Составление программ циклической структуры: цикл с параметром.  *
//****************************************************************************
using System;
namespace pr7
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
                Console.Write("Введите стартовый капитал (initialCapital): ");
                initialCapital = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ежемесячный рост дохода в процентах (pmonthlyGrowthPercent): ");
                monthlyGrowthPercent = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите целевую сумму (targetAmount): ");
                targetAmount = Convert.ToDouble(Console.ReadLine());
                if (initialCapital <= 0 || monthlyGrowthPercent <= 0 || targetAmount <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nОшибка: Введенные значения должны быть больше нуля!");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.ReadKey();
                    return;
                }
                if (targetAmount <= initialCapital)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nОшибка: Целевая сумма должна быть больше стартового капитала!");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.ReadKey();
                    return;
                }
                double Sum = 0; // инициализация накопленной суммы
                double currentIncome = initialCapital;
                int totalMonth = 0; // месяц
                int maxMonth = 10000;
                for (int month = 1; month <= maxMonth; month++)
                {
                    Sum += currentIncome; // накопление текущей суммы
                    if (Sum >= targetAmount)
                    {
                        totalMonth = month;
                        break; // Досрочный выход из цикла при достижении цели
                    }
                    currentIncome = currentIncome * (1 + monthlyGrowthPercent / 100); // увеличение дохода
                }
                double year = (double)totalMonth / 12.0; // расчет лет 
                Console.WriteLine($"\nДаня М. сможет отправиться в тур через {(Math.Round(year, 1))} лет."); 
            }
            catch (Exception e) // обработка исключений (ошибок ввода текста вместо чисел)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nЧто-то пошло не так. Ошибка: " + e.Message); // вывод на экран ошибки
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ReadKey(); // Задержание экрана консоли
            }   
        }
    }
}
