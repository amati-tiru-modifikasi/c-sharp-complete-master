using System;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground.Examples
{
    public static class Quantifying
    {
        /// <summary>
        /// Sample that checks if all the elements of a sequence match a predicate
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void AreAllElementsMatching(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            bool areAllElementsMatching = false;
            if (syntax == QuerySyntax.Query)
            {
                areAllElementsMatching = (from movie in movies
                                          select movie).All(movie => !string.IsNullOrEmpty(movie.Overview));
            }
            else
            {
                areAllElementsMatching = movies.Select(movie => movie)
                                    .All(movie => !string.IsNullOrEmpty(movie.Overview));
            }
            string yesOrNo = areAllElementsMatching ? "Yes" : "No";
            Console.WriteLine($"Are all elements matching ? {yesOrNo}");
        }

        /// <summary>
        /// Sample that checks if one or more elements of a sequence match a predicate 
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void IsAnyElementMatching(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            bool isOneOrMoreElementsMatching = false;
            if (syntax == QuerySyntax.Query)
            {
                isOneOrMoreElementsMatching = (from movie in movies
                                               select movie).Any(movie => movie.VoteAverage >= 9);
            }
            else
            {
                isOneOrMoreElementsMatching = movies.Select(movie => movie)
                                    .Any(movie => movie.VoteAverage >= 9);
            }
            string yesOrNo = isOneOrMoreElementsMatching ? "Yes" : "No";
            Console.WriteLine($"Is there one matching element ? {yesOrNo}");
        }

        /// <summary>
        /// Sample that checks if a sequence contains an element
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void DoesSequenceContainsAnElement(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            bool doesSequenceContainsAnElement = false;
            if (syntax == QuerySyntax.Query)
            {
                doesSequenceContainsAnElement = (from movie in movies
                                                select movie).Contains(new Movie { Id = 2093 }, new MovieIdentifierEqualityComparer());
            }
            else
            {
                doesSequenceContainsAnElement = movies.Select(movie => movie)
                                    .Contains(new Movie { Id = 2093 }, new MovieIdentifierEqualityComparer());
            }
            string yesOrNo = doesSequenceContainsAnElement ? "Yes" : "No";
            Console.WriteLine($"Is there one matching element ? {yesOrNo}");
        }
    }
}