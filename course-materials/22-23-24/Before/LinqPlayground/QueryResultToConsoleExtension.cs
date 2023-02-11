using System;
using System.Collections.Generic;
using LinqPlayground.Models;

namespace LinqPlayground
{
    public static class QueryResultToConsoleExtension
    {
        public static string GetMovieQueryResultText(this ICollection<Entities.Movie> queryResults)
        {
            throw new NotImplementedException();
        }

        public static string GetActorQueryResultText(this ICollection<Entities.Actor> queryResults)
        {
            throw new NotImplementedException();
        }

        public static string GetMovieVMQueryResultText(this ICollection<Movie> queryResults)
        {
            throw new NotImplementedException();
        }
    }
}