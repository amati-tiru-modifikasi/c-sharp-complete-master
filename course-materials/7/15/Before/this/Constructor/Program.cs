using System;
using System.Collections.Generic;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie1 = new Movie();
            Console.WriteLine(movie1);
            Console.WriteLine();
            var actorList = new List<Actor>
            {
                new Actor {Firstname = "Actor", Lastname = "1"},
                new Actor {Firstname = "Actor", Lastname = "2"}
            };
            var movie2 = new Movie("title", "overview", actorList);
            Console.WriteLine(movie2);
            Console.WriteLine();
            actorList.Add(new Actor{Firstname = "Actor", Lastname = "3"});
            var movie3 = new Movie("other title", "other overview", "French", actorList);
            Console.WriteLine(movie3);
        }
    }
}
