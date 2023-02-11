using System;
using System.Collections.Generic;
using LinqPlayground.Data;
using LinqPlayground.Examples;
using System.Linq;

namespace LinqPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = MovieData.GetMovies();
            var enumerator = movies.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"{enumerator.Current.Title}");
            }
            RunSampleMethod(
                "Get all the movies with more than 25.000 voters without using Linq",
                WithoutLinq.FilterMoviesWithMoreThan25kVotes
                );
            RunSampleMethod(
                "Get all the movies",
                Projecting.ProjectAllElementsWithoutTransformation,
                QuerySyntax.Query
                );
            RunSampleMethod(
                "Get all the movies and project them on a new type",
                Projecting.ProjectFieldsOnNewTypeSequence,
                QuerySyntax.Query
                );
            RunSampleMethod(
                "Get all the movies and project them on an anonymous type",
                Projecting.ProjectOnAnonymousTypeSequence,
                QuerySyntax.Query
                );
            RunSampleMethod(
                "Order movies by revenue in ascending manner",
                Ordering.SimpleColumnAscendingOrdering,
                QuerySyntax.Query
                );
            RunSampleMethod(
                "Order movies by revenue in descending manner",
                Ordering.SimpleColumnDescendingOrdering,
                QuerySyntax.Query
                );
            RunSampleMethod(
                "Order movies by number of stars descending and revenue",
                Ordering.MultipleColumnOrdering,
                QuerySyntax.Query
                );
            RunSampleMethod(
                "Get all the movies with more than 25.000 voters",
                Filtering.FilterElementsThatMatchPredicateOnOneField,
                QuerySyntax.Query
                );
            RunSampleMethod(
                "Get all the movies with more than 1.000.000.000 $ revenue and more than 100 popularity",
                Filtering.FilterElementsThatMatchPredicateOnMultipleFields,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Get one and only one movie by id, can throw an exception",
                SingleElementSelection.GetSingleElement,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Get one and only one movie by id, default value no exception",
                SingleElementSelection.GetSingleElementOrDefaultValue,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Get first movie with more than 100 popularity, can throw an exception",
                SingleElementSelection.GetFirstElement,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Get first movie with more than 100 popularity, default value no exception",
                SingleElementSelection.GetFirstElementOrDefaultValue,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Set the name of the actor with id 32653 to Samuel Lee Jackson",
                AssigningAndLooping.AssignSingleElementField,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Set the popularity of all the actors to 10",
                AssigningAndLooping.AssignMultipleElementsField,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Get all the movies and paginate the results",
                Pagination.SelectAllAndPaginate,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Get distinct movies (with different ids)",
                Projecting.GetDistinctElements,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Get distinct popularity ordered descending",
                Projecting.GetDistinctValues,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Checks if all the movies have a non null or empty overview",
                Quantifying.AreAllElementsMatching,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Checks if any movie has 9+ popularity",
                Quantifying.IsAnyElementMatching,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Checks if movies contain a movie",
                Quantifying.DoesSequenceContainsAnElement,
                QuerySyntax.Query
            );
            RunSampleMethod(
                "Compare two movie sequences",
                CompareSequences.CompareTwoSequences,
                QuerySyntax.Query
            );
            RunSampleMethod(
             "Get two hashsets intersection without using LINQ",
             WithoutLinq.GetHashSetsIntersection
             );
            RunSampleMethod(
             "Get two hashsets intersection",
             SetOperations.GetHashSetsIntersection,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Get two Movie lists intersection",
             SetOperations.GetSequencesIntersection,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Get two hashsets exception",
             SetOperations.GetHashSetsException,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Get two hashsets union",
             SetOperations.GetHashSetsUnion,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Get two hashsets concat",
             SetOperations.GetHashSetsConcat,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Get movies, casts and actors inner join",
             Joining.GetSequencesInnerJoin,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Get movies, casts group join",
             Joining.GetSequencesGroupJoin,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Group movies by vote average",
             Grouping.GetSequenceElementsGroupedByFieldValue,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Group movies by vote average and project on an anonymous type",
             Grouping.GetSequenceElementsGroupedByFieldValueAndProject,
             QuerySyntax.Method
             );
            RunSampleMethod(
             "Group movies having more than 10 elements by vote average",
             Grouping.GetSequenceElementsGroupedByFieldValueWithHavingCondition,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Count number of movies",
             Aggregating.CountElementsOfSequence,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Get max movie vote average",
             Aggregating.GetFieldMaxValue,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Get sum movie revenue",
             Aggregating.GetFieldSum,
             QuerySyntax.Query
             );
            RunSampleMethod(
             "Get movie average vote average",
             Aggregating.GetAverage,
             QuerySyntax.Query
             );
            RunSampleMethod(
            "Flatten the movies and associated casts",
            Flattening.GetSequencesFlattening,
            QuerySyntax.Query
            );
            // Get all the actors with more than 
            var actors = ActorData.GetActors();
            QuerySyntax syntax = QuerySyntax.Query;
            IEnumerable<Entities.Actor> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = (
                    from actor in actors
                    where actor.Popularity >= 20
                    select actor
                );
            }
            else
            {
                query = actors.Where(actor => actor.Popularity >= 20);
            }
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetActorQueryResultText());
        }

        private static void RunSampleMethod(string header, Action<QuerySyntax> sampleMethod, QuerySyntax syntax)
        {
            Console.WriteLine();
            Console.WriteLine($"========== {header} ==========");
            Console.WriteLine();
            Console.WriteLine($"Syntax :  {syntax.ToString()}");
            Console.WriteLine();
            sampleMethod(syntax);
        }

        private static void RunSampleMethod(string header, Action sampleMethod)
        {
            Console.WriteLine();
            Console.WriteLine($"========== {header} ==========");
            Console.WriteLine();
            sampleMethod();
        }
    }
}
