using System;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground.Examples
{
    public static class SetOperations
    {
        /// <summary>
        /// Sample that gets the intersection elements of a two hashsets
        /// </summary>
        /// <param name="syntax"></param>
        public static void GetHashSetsIntersection(QuerySyntax syntax)
        {
            FeedHashSets(out var hashset1, out var hashset2);
            PrintEnumerableToConsole(hashset1, nameof(hashset1));
            PrintEnumerableToConsole(hashset2, nameof(hashset2));
            // Intersect using InterSect Linq method
            HashSet<int> intersectHashSet = null;
            if (syntax == QuerySyntax.Query)
            {
                intersectHashSet = (from integer in hashset1
                                    select integer)
                                    .Intersect(hashset2)
                                    .ToHashSet();
            }
            else
            {
                intersectHashSet = hashset1
                                    .Intersect(hashset2)
                                    .ToHashSet();
            }
            PrintEnumerableToConsole(intersectHashSet, nameof(intersectHashSet));
        }

        /// <summary>
        /// Sample that gets the intersection elements of a two sequences
        /// </summary>
        /// <param name="syntax"></param>
        public static void GetSequencesIntersection(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies1 = MovieData.GetMovies();
            var movies2 = MovieData.GetMovies().Skip(10).Take(5);
            // create the query
            IEnumerable<Movie> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = (from movie in movies1
                         select movie)
                        .Intersect(movies2, new MovieEqualityComparer());
            }
            else
            {
                query = movies1.Intersect(movies2, new MovieEqualityComparer());
            }
            // Execute the query
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetMovieQueryResultText());
        }

        /// <summary>
        /// Sample that gets the exception elements of a two hashsets
        /// </summary>
        /// <param name="syntax"></param>
        public static void GetHashSetsException(QuerySyntax syntax)
        {
            FeedHashSets(out var hashset1, out var hashset2);
            PrintEnumerableToConsole(hashset1, nameof(hashset1));
            PrintEnumerableToConsole(hashset2, nameof(hashset2));
            // Except using Except Linq method
            HashSet<int> exceptHashSet = null;
            if (syntax == QuerySyntax.Query)
            {
                exceptHashSet = (from integer in hashset1
                                 select integer)
                                    .Except(hashset2)
                                    .ToHashSet();
            }
            else
            {
                exceptHashSet = hashset1
                                    .Except(hashset2)
                                    .ToHashSet();
            }
            PrintEnumerableToConsole(exceptHashSet, nameof(exceptHashSet));
        }

        /// <summary>
        /// Sample that gets the union elements of a two hashsets
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetHashSetsUnion(QuerySyntax syntax)
        {
            FeedHashSets(out var hashset1, out var hashset2);
            PrintEnumerableToConsole(hashset1, nameof(hashset1));
            PrintEnumerableToConsole(hashset2, nameof(hashset2));
            // Union using Union Linq method
            List<int> unionHashSet = null;
            if (syntax == QuerySyntax.Query)
            {
                unionHashSet = (from integer in hashset1
                                select integer)
                                    .Union(hashset2)
                                    .ToList();
            }
            else
            {
                unionHashSet = hashset1
                                    .Union(hashset2)
                                    .ToList();
            }
            PrintEnumerableToConsole(unionHashSet, nameof(unionHashSet));
        }

        /// <summary>
        /// Sample that gets the concatenation of a two hashsets
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetHashSetsConcat(QuerySyntax syntax)
        {
            FeedHashSets(out var hashset1, out var hashset2);
            PrintEnumerableToConsole(hashset1, nameof(hashset1));
            PrintEnumerableToConsole(hashset2, nameof(hashset2));
            // Concat using Concat Linq method
            List<int> concatHashSet = null;
            if (syntax == QuerySyntax.Query)
            {
                concatHashSet = (from integer in hashset1
                                 select integer)
                                    .Concat(hashset2)
                                    .ToList();
            }
            else
            {
                concatHashSet = hashset1
                                    .Concat(hashset2)
                                    .ToList();
            }
            PrintEnumerableToConsole(concatHashSet, nameof(concatHashSet));
        }

        private static void PrintEnumerableToConsole(IEnumerable<int> list, string listName)
        {
            Console.WriteLine($"{listName}");
            foreach (var element in list)
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