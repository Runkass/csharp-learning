using System;
using System.Text;

namespace myapp
{
    class program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Как вас зовут?");
            string Name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Привет, {Name}.\n Тебе {Age} лет");
            if (Age < 18)
            {
                int diff = 18 - Age;
                Console.WriteLine($"Тебе 18 через {diff} лет");
            }
            else if (Age == 18)
            {
                Console.WriteLine($"Ты совершеннолетний");
            }
            else if (Age > 18)
            {
                int diff = Age - 18;
                Console.WriteLine($"Тебе 18 уже {diff} лет");
            }
        }
    }
}