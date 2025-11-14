using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args){
            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);
            int min = 1;
            int max = 100;
            Console.WriteLine("Поиграем в угадай число!");
            while(true){
                Console.WriteLine($"Введи свое предположение от 1 до 100\n Текущий диапозон: [{min},{max}]");
                if (!int.TryParse(Console.ReadLine(), out int guess)){
                    Console.WriteLine("Введите число!");
                    continue;
                }
                if (guess > 100 || guess < 1)
                {
                    Console.WriteLine("Неправильный ввод!");
                }else if(guess > secretNumber)
                {
                    Console.WriteLine("Меньше");
                    if (max>guess){ max = guess; }
                }else if (guess < secretNumber)
                {
                    Console.WriteLine("Больше");
                    if (min<guess){ min = guess; }

                }else if (guess == secretNumber)
                {
                    Console.WriteLine("Ты угадал!");
                    break;
                }
            }
        }
    }
}