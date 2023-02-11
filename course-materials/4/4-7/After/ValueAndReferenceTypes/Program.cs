using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Value types
            // Value types hold their value
            Console.WriteLine("---Value types---");
            int i = 0;
            int j = i;
            Console.WriteLine($"Before, {nameof(i)} : {i}, {nameof(j)} : {j}");

            i = 1;
            Console.WriteLine($"After, {nameof(i)} : {i}, {nameof(j)} : {j}");

            // Location is a structure
            var location1 = new Location(10, 8, 5);
            var location2 = location1;
            Console.WriteLine($"Before, {nameof(location1)} : {location1}, {nameof(location2)} : {location2}");
            location1.X = 999;
            Console.WriteLine($"After, {nameof(location1)} : {location1}, {nameof(location2)} : {location2}");
            Console.WriteLine($"{nameof(location1)} ReferenceEquals {nameof(location2)} ? : {Object.ReferenceEquals(location1,location2)}");

            #endregion

            #region Reference types
            // Reference type hold a reference to their value memory location
            Console.WriteLine("---Reference types---");
            // Position is a class
            var position1 = new Position(10, 8, 5);
            var position2 = position1;
            Console.WriteLine($"Before, {nameof(position1)} : {position1}, {nameof(position2)} : {position2}");
            position1.X = 999;
            Console.WriteLine($"After, {nameof(position1)} : {position1}, {nameof(position2)} : {position2}");

            // Test if 2 reference object instances point to the same object
            Console.WriteLine($"{nameof(position1)} ReferenceEquals {nameof(position2)} ? : {Object.ReferenceEquals(position1,position2)}");

            #endregion
        }
    }

    internal struct Location
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public Location(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
    }

    internal class Position
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public Position(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
    }
}
