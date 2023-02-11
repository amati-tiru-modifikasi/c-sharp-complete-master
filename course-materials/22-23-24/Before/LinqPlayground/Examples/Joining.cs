using System;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground.Examples
{
    public static class Joining
    {
        /// <summary>
        /// Sample that inner joins two sequences 
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetSequencesInnerJoin(QuerySyntax syntax)
        {
            // Get the data from our data service classes
            var movies = MovieData.GetMovies();
            var casts = CastData.GetCasts();
            var actors = ActorData.GetActors();
            // create the query
            if (syntax == QuerySyntax.Query)
            {
                var query = from movie in movies
                            join cast in casts
                            on movie.Id equals cast.MovieId
                            join actor in actors
                            on cast.ActorId equals actor.Id
                            select new
                            {
                                movie.Title,
                                cast.Character,
                                cast.Order,
                                actor.Name,
                                actor.Popularity
                            };
                // Execute the query 
                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                var query = movies.Join(casts,
                                movie => movie.Id,
                                cast => cast.MovieId,
                                (movie, cast) =>
                                    new
                                    {
                                        movie.Title,
                                        cast.ActorId,
                                        cast.Character,
                                        cast.Order
                                    }
                                ).Join(actors,
                                    castMovie => castMovie.ActorId,
                                    actor => actor.Id,
                                    (castMovie, actor) =>
                                    new
                                    {
                                        castMovie.Title,
                                        castMovie.Character,
                                        castMovie.Order,
                                        actor.Name,
                                        actor.Popularity
                                    }
                                );
                // Execute the query
                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }

        }

        /// <summary>
        /// Sample that group joins two sequences 
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetSequencesGroupJoin(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            var casts = CastData.GetCasts();
            // create the query
            if (syntax == QuerySyntax.Query)
            {
                var query = from movie in movies
                            join cast in casts
                            on movie.Id equals cast.MovieId
                            into movieCasts
                            select new
                            {
                                Movie = movie,
                                Casts = movieCasts
                            };
                // Execute the query
                foreach (var movieCasts in query)
                {
                    Console.WriteLine($"----------{movieCasts.Movie.Title}");
                    Console.WriteLine();
                    Console.WriteLine($"{movieCasts.Movie.Tagline}");
                    Console.WriteLine();
                    Console.WriteLine("----- Cast -----");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (var cast in movieCasts.Casts.OrderBy(cast => cast.Order))
                    {
                        Console.WriteLine($"Character {cast.Order} - {cast.Name}");
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            else
            {
                var query = movies.GroupJoin(casts,
                                movie => movie.Id,
                                cast => cast.MovieId,
                                (movie, movieCasts) =>
                                    new
                                    {
                                        Movie = movie,
                                        Casts = movieCasts
                                    }
                                );
                // Execute the query
                foreach (var movieCasts in query)
                {
                    Console.WriteLine($"----------{movieCasts.Movie.Title}");
                    Console.WriteLine();
                    Console.WriteLine($"{movieCasts.Movie.Tagline}");
                    Console.WriteLine();
                    Console.WriteLine("----- Cast -----");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (var cast in movieCasts.Casts.OrderBy(cast => cast.Order))
                    {
                        Console.WriteLine($"Character {cast.Order} - {cast.Name}");
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
    }
}