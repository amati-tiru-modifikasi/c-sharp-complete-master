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
            Console.WriteLine("--- ReadOnlyCollections ---");
            var list1 = new List<Movie>
            {
                new Movie {Id = 1, Title = "Title 1"},
                new Movie {Id = 2, Title = "Title 2"},
                new Movie {Id = 3, Title = "Title 3"},
            };
            var readonlyCollection1 = new ReadOnlyCollection<Movie>(list1);
            // Compilation error, this collection is read-only and does not contain an Add method
            // readonlyCollection1[0] = new Movie {Id = 4, Title = "Title 4"};
            // readonlyCollection1.Add(new Movie {Id = 4, Title = "Title 4"});

            var list2 = new List<Movie>(list1);
            var readonlyCollection2 = list2.AsReadOnly();

            Console.WriteLine("readonlyCollection2 :");
            foreach (var item in readonlyCollection2)
            {
                Console.WriteLine($"readonlyCollection2[{readonlyCollection2.IndexOf(item)}] = {item.Title}");
            }
            // But this works, you can modify the readonly collection if you have 
            // a reference to the underlying list
            Console.WriteLine();
            Console.WriteLine("readonlyCollection2 after modifying underlying list:");
            list2.Add(new Movie { Id = 4, Title = "Title 4" });
            foreach (var item in readonlyCollection2)
            {
                Console.WriteLine($"readonlyCollection2[{readonlyCollection2.IndexOf(item)}] = {item.Title}");
            }

            Console.WriteLine();

        }
    }
}
