using System;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Data;

namespace LinqPlayground.Examples
{
    public static class Filtering
    {
        /// <summary>
        /// Sample that gets all the elements of a sequence
        /// that match a predicate on a property
        /// Linq version of the method FilterMoviesWithMoreThan25kVotes
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void FilterElementsThatMatchPredicateOnOneField(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<Entities.Movie> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = from movie in movies
                        where movie.VoteCount > 25000
                        select movie;
            }
            else
            {
                query = movies.Where(movie => movie.VoteCount > 25000);
            }
            // Execute the query
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetMovieQueryResultText());
        }

        /// <summary>
        /// Sample that gets all the elements of a sequence
        /// that match a predicate on two properties
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void FilterElementsThatMatchPredicateOnMultipleFields(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<Entities.Movie> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = from movie in movies
                        where movie.Revenue > 1_000_000_000 && movie.Popularity > 100
                        orderby movie.NumberOfStars descending, movie.Revenue descending
                        select movie;
            }
            else
            {
                query = movies.Where(movie => movie.Revenue > 1_000_000_000 && movie.Popularity > 100)
                            .OrderByDescending(movie => movie.NumberOfStars)
                            .ThenByDescending(movie => movie.Revenue);
            }
            // Execute the query
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetMovieQueryResultText());
        }
    }
}