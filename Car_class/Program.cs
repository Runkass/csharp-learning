using System;

namespace myapp
{
    class Car
    {
        private string _brand;
        private int _year;
        private bool _isRunning;

        public Car(string brand, int year)
        {
            _brand = brand;
            _year = year;
            _isRunning = false;
        }

        public void Start()
        {
            if (!_isRunning)
            {
                _isRunning = true;
                Console.WriteLine("Машина запущена!");
            }
            else
            {
                Console.WriteLine("Машина уже запущена!");
            }
        }

        public void Stop()
        {
            if (_isRunning)
            {
                _isRunning = false;
                Console.WriteLine("Машина остановлена!");
            }
            else
            {
                Console.WriteLine("Машина уже остановлена!");
            }
        }

        public void Status()
        {
            Console.WriteLine($"Бренд машины - {_brand}, год выпуска - {_year}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("BMW", 2024);
            car.Start();   // Машина запущена!
            car.Start();   // Машина уже запущена!
            car.Stop();    // Машина остановлена!
            car.Status();  // Бренд машины - BMW, год выпуска - 2024
        }
    }
}