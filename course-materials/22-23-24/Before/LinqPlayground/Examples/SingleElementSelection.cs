using System;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground.Examples
{
    public static class SingleElementSelection
    {
        /// <summary>
        /// Sample that gets one element of a sequence
        /// matching a predicate using the Single method
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetSingleElement(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            Movie movie = null;
            try
            {
                if (syntax == QuerySyntax.Query)
                {
                    // movie = (from movieElement in movies
                    //          select movieElement).Single(movie => movie.Id == 3542);
                    movie = (from movieElement in movies
                             select movieElement).Single(movieElement => movieElement.Id == 0);
                    // movie = (from movieElement in movies
                    //          select movieElement).Single(movie => movie.NumberOfStars == 4);
                }
                else
                {
                    // movie = movies.Single(movie => movie.Id == 3542);
                    movie = movies.Single(movieElement => movieElement.Id == 0);
                    // movie = movies.Single(movie => movie.NumberOfStars == 4);

                }
                Console.WriteLine(movie);
            }
            catch (InvalidOperationException)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("No movie or more than one movie found");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Sample that gets one element of a sequence
        /// matching a predicate using the SingleOrDefault method
        /// </summary>
        /// <param name="syntax">The Linq syntax to execute (query or method)</param>
        public static void GetSingleElementOrDefaultValue(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            Movie movie = null;
            try
            {
                if (syntax == QuerySyntax.Query)
                {
                    // movie = (from movieElement in movies
                    //          select movieElement).SingleOrDefault(movieElement => movieElement.Id == 3542);
                    // movie = (from movieElement in movies
                    //          select movieElement).SingleOrDefault(movie => movie.Id == 0);
                    movie = (from movieElement in movies
                             select movieElement).SingleOrDefault(movie => movie.NumberOfStars == 4);
                }
                else
                {
                    // movie = movies.SingleOrDefault(movieElement => movieElement.Id == 3542);
                    // movie = movies.SingleOrDefault(movie => movie.Id == 0);
                    movie = movies.SingleOrDefault(movie => movie.NumberOfStars == 4);
                }
                if (movie != null)
                {
                    Console.WriteLine(movie);
                }
                else
                {
                    Console.WriteLine("No movie found");
                }
            }
            catch (InvalidOperationException)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("More than one movie found");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Sample that gets the first element of a sequence
        /// matching a predicate using the First method
        /// </summary>
        /// <param name="syntax">The Linq syntax to execute (query or method)</param>
        public static void GetFirstElement(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            Movie movie = null;
            try
            {
                if (syntax == QuerySyntax.Query)
                {
                    // movie = (from movieElement in movies
                    //          select movieElement).First(movie => movie.Popularity > 100);
                    movie = (from movieElement in movies
                             select movieElement).First(movieElement => movieElement.Popularity > 1000);
                }
                else
                {
                    // movie = movies.First(movie => movie.Popularity > 100);
                    movie = movies.First(movieElement => movieElement.Popularity > 1000);
                }
                Console.WriteLine(movie);
            }
            catch (InvalidOperationException)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("No movie found, no element satisfies the predicate condition");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Sample for getting the first element of a sequence
        ///  matching a predicate using the FirstOrDefault method
        /// </summary>
        /// <param name="syntax">The Linq syntax to execute (query or method)</param>
        public static void GetFirstElementOrDefaultValue(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create and execute the query
            Movie movie = null;
            if (syntax == QuerySyntax.Query)
            {
                movie = (from movieElement in movies
                         select movieElement).FirstOrDefault(movieElement => movieElement.Popularity > 100);
                // movie = (from movieElement in movies
                //          select movieElement).FirstOrDefault(movie => movie.Popularity > 1000);
            }
            else
            {
                movie = movies.FirstOrDefault(movieElement => movieElement.Popularity > 100);
                // movie = movies.FirstOrDefault(movie => movie.Popularity > 1000);
            }
            if (movie != null)
            {
                Console.WriteLine(movie);
            }
            else
            {
                Console.WriteLine("No movie found");
            }
        }
    }
}