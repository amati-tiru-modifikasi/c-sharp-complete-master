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

    }
}
