using System;
using System.Collections.Generic;

namespace MyApp
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Рисуем фигуру");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Рисуем круг");
        }
    }    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Рисуем квадрат");
        }
    }
class Program
    {
        static void Main(string[] args)
        {
            List < Shape > Shape = new List<Shape>();
            Shape.Add(new Circle());
            Shape.Add(new Square());
            foreach (Shape shape in Shape){
                shape.Draw();
            }
        }
    }
}