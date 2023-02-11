using System;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground.Examples
{
    public static class Pagination
    {
        private const int NUMBER_OF_ELEMENTS_TO_DISPLAY = 20;

        /// <summary>
        /// Sample that gets all the elements of a sequence
        /// and paginates the result in console. The Console.Readline method
        /// call, lets the caller move to the next page
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void SelectAllAndPaginate(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var movies = MovieData.GetMovies();
            // create the query
            int numberOfElementsToDisplay = Math.Min(movies.Count, NUMBER_OF_ELEMENTS_TO_DISPLAY);
            int numberOfPages = movies.Count % numberOfElementsToDisplay == 0 ?
                                movies.Count / numberOfElementsToDisplay :
                                Math.Abs(movies.Count / numberOfElementsToDisplay) + 1;
            for (var i = 0; i < numberOfPages; i++)
            {
                IEnumerable<Movie> query = null;
                if (syntax == QuerySyntax.Query)
                {
                    query = (from movie in movies
                             select movie)
                             .Skip(i * numberOfElementsToDisplay)
                             .Take(numberOfElementsToDisplay);
                }
                else
                {
                    query = movies.Select(movie => movie)
                            .Skip(i * numberOfElementsToDisplay)
                            .Take(numberOfElementsToDisplay);
                }
                // Execute the query
                var queryResults = query.ToList();
                Console.WriteLine(queryResults.GetMovieQueryResultText());
                Console.WriteLine();
                Console.Write($"Result page {i + 1} - ");
                Console.Write($"element {i * numberOfElementsToDisplay + 1} ");
                Console.Write($"to {Math.Min((i + 1) * numberOfElementsToDisplay, movies.Count)}");
                Console.WriteLine();
                if (i == numberOfPages - 1) break;
                Console.WriteLine("Press enter to display the next result page ...");
                Console.ReadLine();
            }
        }
    }
}