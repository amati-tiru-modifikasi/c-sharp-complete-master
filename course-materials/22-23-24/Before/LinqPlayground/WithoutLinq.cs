using System;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground
{
    public class WithoutLinq
    {
        /// <summary>
        /// Sample that gets all the elements from the movie data list
        /// with more than 25.000 voters without using Linq
        /// </summary>
        public static void FilterMoviesWithMoreThan25kVotes()
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // select the movie with more than 25.000 voters
            // List<Movie> matchingMovies = GetMoviesWithMore25kVotes(movies);
            List<Movie> matchingMovies = GetMoviesWithMore25kVotes_YieldVersion(movies).ToList();
            // 
            foreach (var movie in matchingMovies)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
            Console.WriteLine($"The filtering returned {matchingMovies.Count} movies");
        }        

        private static List<Movie> GetMoviesWithMore25kVotes(List<Movie> movies)
        {
            List<Movie> result = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.VoteCount > 25000)
                {
                    result.Add(movie);
                }
            }
            return result;
        }

        private static IEnumerable<Movie> GetMoviesWithMore25kVotes_YieldVersion(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                if (movie.VoteCount > 25000)
                {
                    yield return movie;
                }
            }
        }

        /// <summary>
        /// Sample that gets two hashsets intersection
        /// without using Linq
        /// </summary>
        public static void GetHashSetsIntersection()
        {
            FeedHashSets(out var hashset1, out var hashset2);
            PrintHashSetToConsole(hashset1, nameof(hashset1));
            PrintHashSetToConsole(hashset2, nameof(hashset2));
            // Intersect using InterSectWith HashSet method
            var intersectHashSet = new HashSet<int>(hashset1);
            intersectHashSet.IntersectWith(hashset2);
            PrintHashSetToConsole(intersectHashSet, nameof(intersectHashSet));
        }

        private static void PrintHashSetToConsole(HashSet<int> hashSet, string hashSetName)
        {
            Console.WriteLine($"{hashSetName}");
            foreach (var element in hashSet)
            {
                Console.WriteLine($"{element}");
            }
        }

        private static void FeedHashSets(out HashSet<int> hashset1, out HashSet<int> hashset2)
        {
            // Declaration
            hashset1 = new HashSet<int>();
            hashset2 = new HashSet<int>();
            // Add elements
            for (int i = 0; i < 5; i++)
            {
                hashset1.Add(i);
                hashset2.Add(i * 2);
            }
        }
    }
}