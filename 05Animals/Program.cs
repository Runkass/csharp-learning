using System;
using System.Collections.Generic;

namespace AbstractAnimals
{
    abstract class Animal
    {
        public abstract void MakeSound();
    }
    class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Гав");
    }
    class Cat : Animal
    {
        public override void MakeSound()=> Console.WriteLine("Мяу");
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Dog());
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}