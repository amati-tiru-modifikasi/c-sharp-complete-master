using System;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground.Examples
{
    public static class CompareSequences
    {
        /// <summary>
        /// Sample that compares two sequences
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void CompareTwoSequences(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies1 = MovieData.GetMovies();
            var movies2 = MovieData.GetMovies();
            // var movieToAdd = new Movie
            // {
            //     Id = 1,
            //     ReleaseDate = DateTime.Now,
            //     Budget = 1_000_000,
            //     Revenue = null,
            //     Runtime = 90,
            //     Title = "Title",
            //     Overview = "Overview",
            //     Popularity = 0,
            //     Tagline = "Tagline",
            //     VoteAverage = 0,
            //     VoteCount = 0
            // };
            // movies2.Add(movieToAdd);
            // create and execute the query
            bool areSequenceEqual = false;
            if (syntax == QuerySyntax.Query)
            {
                areSequenceEqual = (from movie in movies1
                                    select movie).SequenceEqual(movies2, new MovieEqualityComparer());
            }
            else
            {
                areSequenceEqual = movies1.SequenceEqual(movies2, new MovieEqualityComparer());
            }
            string yesOrNo = areSequenceEqual ? "Yes" : "No";
            Console.WriteLine($"Are sequences equal ? {yesOrNo}");
        }
    }
}