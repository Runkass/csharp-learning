using System;
using System.Collections.Generic;

namespace interfaces
{
    interface IMove
    {
        void Move();
    }
    interface IMakeSound
    {
        void MakeSound();
    }
    interface IAnimal : IMakeSound, IMove { }
    interface IFly
    {
        public void Fly();
    }
    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Мяу");
        }
        public void Move()
        {
            Console.WriteLine("Вольяжно идет");
        }
    }
    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Гав");
        }
        public void Move()
        {
            Console.WriteLine("Бежит");
        }
    }
    class Bird: IAnimal, IFly
    {
        public void MakeSound()
        {
            Console.WriteLine("Пипипи");
        }
        public void Move()
        {
            Console.WriteLine("Идет");
        }public void Fly()
        {
            Console.WriteLine("Летит");
        }
    }
    class Program()
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Bird());
            foreach (IAnimal animal in animals)
            {
                animal.MakeSound();
                animal.Move();
                if (animal is IFly flyer)
                {
                    flyer.Fly();
                }
            }
        }
    }
}