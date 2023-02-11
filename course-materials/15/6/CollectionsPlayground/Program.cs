using System;
using System.Collections.Generic;
using System.IO;

namespace CoolectionsPlaygrouund
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<Movie, IList<Actor>>();
            // var dictionary = new Dictionary<Movie, IList<Actor>>(new MovieEqualityComparer());
            // var movie = new Movie { Id = 1, Title = "Title 1" };
            dictionary.Add(
                new Movie { Id = 1, Title = "Title 1" },
                new List<Actor>
                {
                    new Actor{FirstName="FirstName1", LastName = "LastName1"},
                    new Actor{FirstName="FirstName2", LastName = "LastName2"}
            });
            dictionary.Add(
                new Movie { Id = 1, Title = "Title 2" },
                new List<Actor>
                {
                    new Actor{FirstName="FirstName3", LastName = "LastName3"},
                    new Actor{FirstName="FirstName4", LastName = "LastName4"}
            });
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key.Id} - {key.Title}");
                foreach (var actor in dictionary[key])
                {
                    Console.WriteLine($"Actor : {actor.FirstName} - {actor.LastName}");
                }
            }
        }

    }
}
