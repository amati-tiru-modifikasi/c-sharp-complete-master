using System;
using System.Linq;
using LinqPlayground.Data;

namespace LinqPlayground.Examples
{
    public static class Aggregating
    {
        /// <summary>
        /// Sample that counts the number of elements of a sequence
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void CountElementsOfSequence(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            int numberOfElements;
            if (syntax == QuerySyntax.Query)
            {
                numberOfElements = (from movie in movies
                                    select movie).Count();
            }
            else
            {
                numberOfElements = movies.Count();
            }
            Console.WriteLine($"Number of elements : {numberOfElements}");
        }

        /// <summary>
        /// Sample that gets the max value of an element object field 
        /// within a sequence
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetFieldMaxValue(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            int max;
            if (syntax == QuerySyntax.Query)
            {
                max = (from movie in movies
                       select movie.VoteAverage).Max();
            }
            else
            {
                max = movies.Max(movie => movie.VoteAverage);
            }
            Console.WriteLine($"Max vote average : {max}");
        }

        /// <summary>
        /// Sample that gets the sum of all the element objects field 
        /// within a sequence
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetFieldSum(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            long? sum;
            if (syntax == QuerySyntax.Query)
            {
                sum = (from movie in movies
                       select movie.Revenue).Sum();
            }
            else
            {
                sum = movies.Sum(movie => movie.Revenue);
            }
            Console.WriteLine($"Movies revenue sum : {sum:c}");
        }

        /// <summary>
        /// Sample that gets the average of all the element objects field 
        /// within a sequence
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetAverage(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            double averageRating;
            if (syntax == QuerySyntax.Query)
            {
                averageRating = (from movie in movies
                                 select movie.VoteAverage).Average();
            }
            else
            {
                averageRating = movies.Average(movie => movie.VoteAverage);
            }
            Console.WriteLine($"Vote average : {averageRating:G2}/10");
        }
    }
}