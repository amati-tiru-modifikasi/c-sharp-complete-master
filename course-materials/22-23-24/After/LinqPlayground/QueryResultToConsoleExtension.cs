using System;
using System.Collections.Generic;
using System.Text;
using LinqPlayground.Models;

namespace LinqPlayground
{
    public static class QueryResultToConsoleExtension
    {
        public static string GetMovieQueryResultText(this ICollection<Entities.Movie> queryResults)
        {
            var stringBuilder = new StringBuilder();
            foreach (var movie in queryResults)
            {
                stringBuilder.AppendLine(movie.ToString());
            }
            stringBuilder.AppendLine($"The query returned {queryResults.Count} movies");
            return stringBuilder.ToString();
        }

        public static string GetActorQueryResultText(this ICollection<Entities.Actor> queryResults)
        {
            var stringBuilder = new StringBuilder();
            foreach (var movie in queryResults)
            {
                stringBuilder.AppendLine(movie.ToString());
            }
            stringBuilder.AppendLine($"The query returned {queryResults.Count} actors");
            return stringBuilder.ToString();
        }

        public static string GetMovieVMQueryResultText(this ICollection<Movie> queryResults)
        {
            var stringBuilder = new StringBuilder();
            foreach (var movie in queryResults)
            {
                stringBuilder.AppendLine(movie.ToString());
            }
            stringBuilder.AppendLine($"The query returned {queryResults.Count} movies");
            return stringBuilder.ToString();
        }
    }
}