using System;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground.Examples
{
    public static class Projecting
    {
        /// <summary>
        /// Sample that projects all the elements of a sequence without 
        /// transformation
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void ProjectAllElementsWithoutTransformation(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<Movie> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = from movie in movies
                        select movie;
            }
            else
            {
                query = movies.Select(movie => movie);
            }
            // Execute the query
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetMovieQueryResultText());
        }

        /// <summary>
        /// Sample that projects the fields of a sequence
        /// on a new type
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void ProjectFieldsOnNewTypeSequence(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<Models.Movie> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = from movie in movies
                        select new Models.Movie
                        {
                            ReleaseDate = movie.ReleaseDate,
                            Title = movie.Title,
                            Overview = movie.Overview,
                            VoteAverage = movie.VoteAverage,
                            VoteCount = movie.VoteCount
                        };
            }
            else
            {
                query = movies.Select(movie => new Models.Movie
                {
                    ReleaseDate = movie.ReleaseDate,
                    Title = movie.Title,
                    Overview = movie.Overview,
                    VoteAverage = movie.VoteAverage,
                    VoteCount = movie.VoteCount
                });
            }
            // Execute the query
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetMovieVMQueryResultText());
        }

        /// <summary>
        /// Sample that projects the fields of a sequence
        /// on an anonymous type
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void ProjectOnAnonymousTypeSequence(QuerySyntax syntax)
        {
            var movies = MovieData.GetMovies();
            if (syntax == QuerySyntax.Query)
            {
                var query = from movie in movies
                            select new
                            {
                                movie.Title,
                                movie.NumberOfStars,
                                movie.ReleaseDate,
                                movie.Tagline
                            };
                var queryResults = query.ToList();
                foreach (var item in queryResults)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"The query returned {queryResults.Count} movies");
            }
            else
            {
                var query = movies.Select(
                    movie => new
                    {
                        movie.Title,
                        movie.NumberOfStars,
                        movie.ReleaseDate,
                        movie.Tagline
                    });
                var queryResults = query.ToList();
                foreach (var movie in queryResults)
                {
                    Console.WriteLine(movie);
                }
                Console.WriteLine($"The query returned {queryResults.Count} movies");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Sample that gets the distinct values of a field of a sequence
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetDistinctElements(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<Movie> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = (from movie in movies
                         select movie).Distinct(new MovieIdentifierEqualityComparer());
            }
            else
            {
                query = movies.Select(movie => movie).Distinct(new MovieIdentifierEqualityComparer());
            }
            // Execute the query
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetMovieQueryResultText());
        }

        /// <summary>
        /// Sample that gets the distinct elements of a field of a sequence
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetDistinctValues(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<int> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = (from movie in movies
                         orderby movie.Popularity descending
                         select movie.Popularity).Distinct();
            }
            else
            {
                query = movies.OrderByDescending(movie => movie.Popularity).Select(movie => movie.Popularity).Distinct();
            }
            // Execute the query
            var queryResults = query.ToList();
            foreach (var popularity in queryResults)
            {
                Console.WriteLine(popularity);
            }
        }
    }
}