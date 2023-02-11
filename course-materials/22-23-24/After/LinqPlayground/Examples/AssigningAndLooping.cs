using System;
using System.Collections.Generic;
using System.Linq;
using LinqPlayground.Data;
using LinqPlayground.Entities;

namespace LinqPlayground.Examples
{
    public static class AssigningAndLooping
    {
        /// <summary>
        /// Sample that assigns a value to an element object field
        /// within a sequence
        /// </summary>
        /// <param name="syntax">The syntax to use (query or method)</param>
        public static void AssignSingleElementField(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var actors = ActorData.GetActors();
            // create and execute the query
            try
            {
                Actor actor = null;
                if (syntax == QuerySyntax.Query)
                {
                    actor = (from actorElement in actors
                             where actorElement.Id == 32653
                             let element = actorElement.Name = "Samuel Lee Jackson"
                             select actorElement).Single();
                }
                else
                {
                    actor = actors.Single(actor => actor.Id == 32653);
                    actor.Name = "Samuel Lee Jackson";
                }
                Console.WriteLine(actor);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No actor found with this id");
            }
        }

        /// <summary>
        /// Sample that assigns a value to several element objects field
        /// within a sequence
        /// </summary>
        /// <param name="syntax">The Linq syntax to execute (query or method)</param>
        public static void AssignMultipleElementsField(QuerySyntax syntax)
        {
            // Get the data from our data service class
            var actors = ActorData.GetActors();
            // create the query
            IEnumerable<Actor> query = null;
            if (syntax == QuerySyntax.Query)
            {
                query = from actorElement in actors
                        let element = actorElement.Popularity = 10
                        select actorElement;
            }
            else
            {
                actors.ForEach(actor => actor.Popularity = 10);
                query = actors.Select(actor => actor);
            }
            var queryResults = query.ToList();
            Console.WriteLine(queryResults.GetActorQueryResultText());
        }
    }
}