using System;
using System.Collections.Generic;

namespace CollectionsPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {1, 2, 3, 4};
            var movies = GetMoviesFromArray(intArray);
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }

        private static IEnumerable<Movie> GetMoviesFromArray(int[] intArray)
        {
            foreach (var item in intArray)
            {
                yield return new Movie{ Id = item, Title = $"Title {item}"};
            }
        }
    }
}
