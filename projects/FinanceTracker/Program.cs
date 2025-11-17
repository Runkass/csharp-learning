//Program.cs
using System;
using System.Collections.Generic; //для Листов
using System.Text.Json;// для Json
using System.IO;// Для работы с файлами

namespace FinanceTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new TransactionService();
            Console.WriteLine("Добро пожаловать в Финансовый трекер.");
            while (true)
            {
                Console.WriteLine(" Выберете необходимую вам функцию:\n 1. Добавить доход. \n 2. Добавить расход\n 3. Показать баланс\n 0. Выход");
                var choise = Console.ReadLine();
                switch (choise)
                {
                    case "0":
                        {
                            return;
                        }
                    case "1":
                    case "2":
                        {
                            Console.WriteLine("Введите категорию: ");
                            string category = Console.ReadLine() ?? "Без категории";
                            Console.WriteLine("Введите Сумму: ");
                            decimal amount;
                            while (!decimal.TryParse(Console.ReadLine(), out amount))
                            {
                                Console.WriteLine("Неправильный ввод, повторите: ");
                            }
                            string type = choise == "1" ? "income" : "expense";
                            service.Add(new Transaction(category, amount, DateTime.Now, type));
                            Console.WriteLine("Успех");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine($"Текущий баланс: {service.GetBalance():F2} ");
                        }
                        break;
                    default: Console.WriteLine("Выберите правильный вариант"); break;

                }
            }
        }
    }
}