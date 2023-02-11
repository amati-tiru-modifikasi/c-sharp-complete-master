using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace CollectionsPlayground
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- ReadOnlyDictionary ---");

            var dictionary = new Dictionary<int, Movie>
            {
                {1, new Movie {Id = 1, Title = "Title 1"}},
                {2, new Movie {Id = 2, Title = "Title 2"}},
                {3, new Movie {Id = 3, Title = "Title 3"}},
            };
            var readonlyDictionary = new ReadOnlyDictionary<int, Movie>(dictionary);
            // Compilation error, this collection is read-only and does not contain an Add method
            // readonlyDictionary1[1] = new Movie {Id = 4, Title = "Title 4"};
            // readonlyDictionary1.Add(new Movie {Id = 4, Title = "Title 4"});

            Console.WriteLine("readonlyDictionary :");
            foreach (var item in readonlyDictionary)
            {
                Console.WriteLine($"readonlyDictionary[{item.Key}] = {item.Value.Title}");
            }

            // But this works, you can modify the readonly dictionary if you have 
            // a reference to the underlying dictionary
            Console.WriteLine();
            Console.WriteLine("readonlyDictionary after modifying underlying dictionary:");
            dictionary.Add(4, new Movie { Id = 4, Title = "Title 4" });
            foreach (var item in readonlyDictionary)
            {
                Console.WriteLine($"readonlyDictionary[{item.Key}] = {item.Value.Title}");
            }
            Console.WriteLine();
        }
    }
}
