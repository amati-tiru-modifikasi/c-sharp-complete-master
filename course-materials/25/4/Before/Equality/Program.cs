using System;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void PrimitivesEquality()
        {
            int i1 = 100;
            int i2 = 100;
            Console.WriteLine($"{nameof(i1)} == {nameof(i2)} returns {i1 == i2}");
            Console.WriteLine($"Equals({nameof(i1)},{nameof(i2)}) returns {Equals(i1, i2)}");
            Console.WriteLine($"{nameof(i1)}.ReferenceEquals({nameof(i2)}) returns {ReferenceEquals(i1, i2)}");
            Console.WriteLine($"{nameof(i1)}.GetHashCode() = {i1.GetHashCode()}");
            Console.WriteLine($"{nameof(i2)}.GetHashCode() = {i2.GetHashCode()}");
        }

        private static void StructuresEquality()
        {
            Point p1 = new(3, 2, 10);
            Point p2 = new(3, 2, 10);
            Console.WriteLine($"Equals({nameof(p1)},{nameof(p2)}) returns {Equals(p1, p2)}");
            Console.WriteLine($"{nameof(p1)}.ReferenceEquals({nameof(p2)}) returns {ReferenceEquals(p1, p2)}");
            Console.WriteLine($"{nameof(p1)}.GetHashCode() = {p1.GetHashCode()}");
            Console.WriteLine($"{nameof(p2)}.GetHashCode() = {p2.GetHashCode()}");
        }

        private static void ClassEquality()
        {
            Movie movie1 = new(1, "Movie1", "Description 1");
            Movie movie2 = new(1, "Movie1", "Description 1");
            Console.WriteLine($"{nameof(movie1)} == {nameof(movie2)} returns {movie1 == movie2}");
            Console.WriteLine($"Equals({nameof(movie1)},{nameof(movie2)}) returns {Equals(movie1, movie2)}");
            Console.WriteLine($"{nameof(movie1)}.ReferenceEquals({nameof(movie2)}) returns {ReferenceEquals(movie1, movie2)}");
            Console.WriteLine($"{nameof(movie1)}.GetHashCode() = {movie1.GetHashCode()}");
            Console.WriteLine($"{nameof(movie2)}.GetHashCode() = {movie2.GetHashCode()}");
        }

        private static void StringEquality()
        {
            string s1 = "I love C#";
            string s2 = "I love C#";
            Console.WriteLine($"{nameof(s1)} == {nameof(s2)} returns {s1 == s2}");
            Console.WriteLine($"Equals({nameof(s1)},{nameof(s2)}) returns {Equals(s1, s2)}");
            Console.WriteLine($"{nameof(s1)}.ReferenceEquals({nameof(s2)}) returns {ReferenceEquals(s1, s2)}");
            Console.WriteLine($"{nameof(s1)}.GetHashCode() = {s1.GetHashCode()}");
            Console.WriteLine($"{nameof(s2)}.GetHashCode() = {s2.GetHashCode()}");
        }
    }
}
