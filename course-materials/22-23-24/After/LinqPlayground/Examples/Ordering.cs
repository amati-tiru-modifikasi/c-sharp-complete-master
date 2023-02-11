using System;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Data;

namespace LinqPlayground.Examples
{
    public static class Ordering
    {
        /// <summary>
        /// Sample that gets all the elements of a sequence
        /// ordered by one field value in an ascending order
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void SimpleColumnAscendingOrdering(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<Entities.Movie> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = from movie in movies
                        orderby movie.Revenue
                        select movie;
            }
            else
            {
                query = movies.OrderBy(movie => movie.Revenue);
            }
            // Execute the query
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetMovieQueryResultText());
        }

        /// <summary>
        /// Sample that gets all the elements of a sequence
        /// ordered by one field value in an descending order
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void SimpleColumnDescendingOrdering(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<Entities.Movie> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = from movie in movies
                        orderby movie.Revenue descending
                        select movie;
            }
            else
            {
                query = movies.OrderByDescending(movie => movie.Revenue);
            }
            // Execute the query
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetMovieQueryResultText());
        }

        /// <summary>
        /// Sample that gets all the elements of a sequence
        /// ordered by more than one field value
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void MultipleColumnOrdering(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<Entities.Movie> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = from movie in movies
                        orderby movie.NumberOfStars descending, movie.Revenue
                        select movie;
            }
            else
            {
                query = movies.OrderByDescending(movie => movie.NumberOfStars)
                            .ThenBy(movie => movie.Revenue); // Also possible to use the ThenByDescending
            }
            // Execute the query
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetMovieQueryResultText());
        }

        
    }
}