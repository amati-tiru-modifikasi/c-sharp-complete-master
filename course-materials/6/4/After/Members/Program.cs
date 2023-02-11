using System;
using Conversions;
using Services;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your mass in kilograms");
            var massInput = Console.ReadLine();
            if (float.TryParse(massInput, out var mass))
            {
                Console.WriteLine($"Your Weight equals {WeightConverter.Convert(mass)} Newtons");
            }
            else
            {
                Console.WriteLine($"Invalid input");                
            }

            var movies = new MovieService().GetMovies();
            foreach (var movie in  movies)
            {
                Console.WriteLine($"First movie description :\n{movie.Description}");
            }
        }
    }
}
