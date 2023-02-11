using System;
using System.Collections.Generic;
using Shapes.Curves;
using Shapes.Polygons;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>{
                new Ellipsis(4, 5),
                new Circle(4),
                new Rectangle(4, 5),
                new Square(4),
                new Triangle(4, 5)
            };
            
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.Name} area : {shape.CalculateArea()}");
            }
        }
    }
}
