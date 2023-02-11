using System;

namespace Immutability
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> ImmutableMovieSample");
            Console.WriteLine("--------------------------------------");
            var immutableMovie = new Movie(1, "Immutable Movie", "Immutable Movie Description");
            Console.WriteLine($"Before reassignment {immutableMovie}");
            immutableMovie = immutableMovie.ChangeDescription( "Modified description");
            immutableMovie = immutableMovie.AddAward(new Award("Award1"));
            Console.WriteLine($"After reassignment {immutableMovie}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }
    }
}
