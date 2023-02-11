using System;

namespace Immutability
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> MutableMovieSample");
            Console.WriteLine("--------------------------------------");
            var mutableMovie = new Movie(1, "Mutable Movie", "Mutable Movie Description");
            Console.WriteLine($"Before change {mutableMovie}");
            mutableMovie.Description = "Modified description";
            mutableMovie.AddAward(new Award("Award1"));
            Console.WriteLine($"After change {mutableMovie}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }
    }
}
