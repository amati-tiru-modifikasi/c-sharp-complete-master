using System;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground.Examples
{
    public static class Grouping
    {
        /// <summary>
        /// Sample that gets all the elements of a sequence
        /// grouped by the value of a field 
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetSequenceElementsGroupedByFieldValue(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<IGrouping<int, Movie>> voteAverageGroupQuery = null;
            if (syntax == QuerySyntax.Query)
            {
                voteAverageGroupQuery = from movie in movies
                                        group movie by movie.VoteAverage into averageMoviesGrouping
                                        select averageMoviesGrouping;
            }
            else
            {
                voteAverageGroupQuery = movies
                        .GroupBy(movie => movie.VoteAverage);
            }
            // Execute the query
            foreach (var group in voteAverageGroupQuery)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{group.Count()} movies have a vote average of {group.Key} ");
                Console.ResetColor();
                Console.WriteLine();
                foreach (var movie in group)
                {
                    Console.WriteLine(movie);
                }
            }
        }

        /// <summary>
        /// Sample that gets all the elements of a sequence
        /// grouped by the value of a field and project each group
        /// on an anonymous type  
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetSequenceElementsGroupedByFieldValueAndProject(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            if (syntax == QuerySyntax.Query)
            {
                var voteAverageGroupQuery = from movie in movies
                                            group movie by movie.VoteAverage into averageMoviesGrouping
                                            let moviesInGroupKey = averageMoviesGrouping.Select(movieGroup => movieGroup)
                                            select new
                                            {
                                                VoteAverage = averageMoviesGrouping.Key,
                                                Movies = moviesInGroupKey,
                                                Count = moviesInGroupKey.Count()
                                            };
                foreach (var item in voteAverageGroupQuery)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Vote average : {item.VoteAverage}");
                    Console.WriteLine($"Number of movies in group : {item.Count}");
                    Console.ResetColor();
                    Console.WriteLine();
                    foreach (var movie in item.Movies)
                    {
                        Console.WriteLine(movie);
                    }
                }
            }
            else
            {
                var voteAverageGroupQuery = movies
                        .GroupBy(
                            movie => movie.VoteAverage,
                            movie => movie,
                            (voteAverage, moviesInGroupKey) => new
                            {
                                VoteAverage = voteAverage,
                                Movies = moviesInGroupKey,
                                Count = moviesInGroupKey.Count()
                            });
                foreach (var item in voteAverageGroupQuery)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Vote average : {item.VoteAverage}");
                    Console.WriteLine($"Number of movies in group : {item.Count}");
                    Console.ResetColor();
                    Console.WriteLine();
                    foreach (var movie in item.Movies)
                    {
                        Console.WriteLine(movie);
                    }
                }
            }
        }

        /// <summary>
        /// Sample that gets all the elements of a sequence
        /// grouped by the value of a field with a having condition
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void GetSequenceElementsGroupedByFieldValueWithHavingCondition(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            IEnumerable<IGrouping<int, Movie>> voteAverageGroupQuery = null;
            if (syntax == QuerySyntax.Query)
            {
                voteAverageGroupQuery = from movie in movies
                                        group movie by movie.VoteAverage into averageMoviesGrouping
                                        where averageMoviesGrouping.Count() > 10
                                        select averageMoviesGrouping;
            }
            else
            {
                voteAverageGroupQuery = movies
                        .GroupBy(movie => movie.VoteAverage)
                        .Where(voteAverages => voteAverages.Count() > 10);
            }
            // Execute the query
            foreach (var group in voteAverageGroupQuery)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{group.Count()} movies have a vote average of {group.Key} ");
                Console.ResetColor();
                Console.WriteLine();
                foreach (var movie in group)
                {
                    Console.WriteLine(movie);
                }
            }
        }
    }
}