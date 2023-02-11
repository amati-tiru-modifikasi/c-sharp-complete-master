using System;
using System.Collections.Generic;
using System.IO;

namespace MostUsedCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Dictionary ---");
            // declaration, initialization
            // var dictionary1 = new Dictionary<int, Movie>();
            // dictionary1.Add(2, new Movie { Id = 2, Title = "Title 2" });
            // dictionary1.Add(1, new Movie { Id = 1, Title = "Title 1" });
            // dictionary1.Add(3, new Movie { Id = 3, Title = "Title 3" });
            // dictionary1.Add(4, new Movie { Id = 4, Title = "Title 4" });

            var dictionary1 = new Dictionary<int, Movie>
            {
                {2 , new Movie{ Id = 2 , Title = "Title 2" }},
                {1 , new Movie{ Id = 1 , Title = "Title 1" }},
                {3 , new Movie{ Id = 3 , Title = "Title 3" }},
                {4 , new Movie{ Id = 4 , Title = "Title 4" }}
            };
            // foreach
            Console.WriteLine("dictionary1");
            foreach (KeyValuePair<int, Movie> element in dictionary1)
            {
                Console.WriteLine($"Id : {element.Value.Id} - Title : {element.Value.Title}");
            }
            for (var i = 1; i < dictionary1.Count + 1; i++)
            {
                Console.WriteLine($"Id {dictionary1[i].Id} - Title : {dictionary1[i].Title}");
            }
            // Dictionaries are not ordered
            Console.WriteLine("dictionary1");
            foreach (var element in dictionary1)
            {
                Console.WriteLine($"{element.Value.Title}");
            }
            // Look up
            var movie1 = dictionary1[1];
            // Remove
            dictionary1.Remove(4);
            // Add, TryAdd
            dictionary1.Add(3, new Movie { Id = 4, Title = "Title 4" });
            var success3 = dictionary1.TryAdd(3, new Movie { Id = 4, Title = "Title 4" });
            Console.WriteLine($"Success TryAdd 3 ? {success3}");
            var success4 = dictionary1.TryAdd(4, new Movie { Id = 4, Title = "Title 4" });
            if (success4)
            {
                Console.WriteLine("Add element OK");
            }
            else
            {
                Console.WriteLine("Add element KO");
            }
            Console.WriteLine($"Success TryAdd 4 ? {success4}");
            foreach (var element in dictionary1)
            {
                Console.WriteLine($"Id : {element.Value.Id} - Title : {element.Value.Title}");
            }
            // TryGetValue
            var success1 = dictionary1.TryGetValue(1, out var dictionary1Element1);
            Console.WriteLine($"Success TryGetValue 1 ? {success1}");
            var success2 = dictionary1.TryGetValue(100, out var dictionary1Element2);
            Console.WriteLine($"Success TryGetValue 100 ? {success2}");
            // ContainsKey
            Console.WriteLine($"Dictionary contains key 1 ? {dictionary1.ContainsKey(1)}");
            Console.WriteLine($"Dictionary contains key 100 ? {dictionary1.ContainsKey(100)}");
            // See Object.GetHashCode
            foreach (var key in dictionary1.Keys)
            {
                Console.WriteLine($"key : {key}");
            }
            foreach (var value in dictionary1.Values)
            {
                Console.WriteLine($"value : Id {value.Id} - Title : {value.Title}");
            }
            for (var i = 1; i < dictionary1.Count + 1; i++)
            {
                Console.WriteLine($"Id {dictionary1[i].Id} - Title : {dictionary1[i].Title}");
            }

            var dictionary2 = new Dictionary<string, Movie>
            {
                {"MOV2" , new Movie{ Id = 2 , Title = "Title 2" }},
                {"MOV1" , new Movie{ Id = 1 , Title = "Title 1" }},
                {"MOV3" , new Movie{ Id = 3 , Title = "Title 3" }},
                {"MOV4" , new Movie{ Id = 4 , Title = "Title 4" }}
            };
            var movie2 = dictionary2["MOV1"];
            foreach (var key in dictionary2.Keys)
            {
                Console.WriteLine($"Id {dictionary2[key].Id} - Title : {dictionary2[key].Title}");
            }
        }
    }
}
