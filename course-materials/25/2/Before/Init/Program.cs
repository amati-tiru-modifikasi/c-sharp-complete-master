using System;

namespace Init
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> MutableMovieSample");
            Console.WriteLine("--------------------------------------");
            var mutableMovie = new Movie(1, "Movie title", "Movie description");
            Console.WriteLine($"Before change {mutableMovie}");
            mutableMovie.Description = "Changed!!!";
            Console.WriteLine($"After change {mutableMovie}");
            Console.WriteLine("--------------------------------------");
        }

    }
}

