using System;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground.Examples
{
    public static class Flattening
    {
        /// <summary>
        /// Sample that flattens two sequences 
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetSequencesFlattening(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            var casts = CastData.GetCasts();
            FeedNavigationProperties(movies, casts);
            // create the query
            if (syntax == QuerySyntax.Query)
            {
                var query = from movie in movies
                            from cast in movie.Casts
                            select new
                            {
                                movie.Title,
                                movie.Popularity,
                                cast.Name,
                                cast.Character
                            };
                // Execute the query
                foreach (var movieCast in query)
                {
                    Console.WriteLine(movieCast);
                }
            }
            else
            {
                var query = movies.SelectMany(movie => movie.Casts,
                                                    (movie, cast) =>
                                                    new
                                                    {
                                                        movie.Title,
                                                        movie.Popularity,
                                                        cast.Name,
                                                        cast.Character
                                                    });
                // Execute the query
                foreach (var movieCast in query)
                {
                    Console.WriteLine(movieCast);
                }
            }
        }


        private static void FeedNavigationProperties(List<Movie> movies, List<Cast> casts)
        {
            foreach (var movie in movies)
            {
                var associatedCasts = casts.Where(cast => cast.MovieId == movie.Id).ToList();
                foreach (var cast in associatedCasts)
                {
                    cast.Movie = movie;
                }
                movie.Casts = associatedCasts;
            }
        }
    }
}