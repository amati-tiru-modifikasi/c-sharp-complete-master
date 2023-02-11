using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new(10, 20, 5);
            var p2 = new Point(20, 5, 1);
            // using parameterless ctor
            var p3 = new Point
            {
                X = 20,
                Y = 10,
                Z = 40
            };
            var p0 = Point.Origin;
            Console.WriteLine($"{nameof(p0)} : {p0}");
            Console.WriteLine($"{nameof(p1)} : {p1}");
            Console.WriteLine($"{nameof(p2)} : {p2}");
            Console.WriteLine($"{nameof(p3)} : {p3}");
            p1.SetToOrigin();
            Console.WriteLine($"{nameof(p1)} : {p1}");

        }
    }
}
