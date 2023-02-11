using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassSample();
            RecordSample();
        }

        public static void ClassSample()
        {
            Console.WriteLine("> ClassSample");
            Console.WriteLine("--------------------------------------");
            var movie = new Classes.Movie(1, "Movie Title", "Movie Description");
            Console.WriteLine($"{nameof(movie)} : {movie}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }

        private static void RecordSample()
        {
            Console.WriteLine("> RecordSample");
            Console.WriteLine("--------------------------------------");
            var movie = new Movie(1, "Movie Title", "Movie Description");
            Console.WriteLine($"{nameof(movie)} : {movie}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }

        private static void Equality()
        {
            Console.WriteLine("> Equality");
            Console.WriteLine("--------------------------------------");
            var movie1 = new Records.Movie(1, "Movie Title", "Movie Description");
            var movie2 = new Records.Movie(2, "Movie Title", "Movie Description");
            Console.WriteLine($"{nameof(movie1)} == {nameof(movie2)} ? {movie1 == movie2}");
            Console.WriteLine($"Equals({nameof(movie1)},{nameof(movie2)}) ? {Equals(movie1, movie2)}");
            Console.WriteLine($"{nameof(movie1)}.ReferenceEquals({nameof(movie2)}) ? {ReferenceEquals(movie1, movie2)}");
            Console.WriteLine($"{nameof(movie1)}.GetHashCode() = {movie1.GetHashCode()}");
            Console.WriteLine($"{nameof(movie2)}.GetHashCode() = {movie2.GetHashCode()}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }

    }
}
