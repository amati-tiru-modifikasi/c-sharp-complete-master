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
            #region ImmutableArray

            // Add System.Collections.Immutable package

            Console.WriteLine("--- ImmutableArray ---");
            var list4 = new List<Movie>
            {
                new Movie {Id = 1, Title = "Title 1"},
                new Movie {Id = 2, Title = "Title 2"},
                new Movie {Id = 3, Title = "Title 3"},
            };
            var immutableArray = list4.ToImmutableArray();
            Console.WriteLine("immutableArray:");
            foreach (var item in immutableArray)
            {
                Console.WriteLine($"immutableArray[{immutableArray.IndexOf(item)}] = {item.Title}");
            }
            list4.Add(new Movie { Id = 4, Title = "Title 4" });
            Console.WriteLine();
            Console.WriteLine("immutableArray after modifying underlying list:");
            foreach (var item in immutableArray)
            {
                Console.WriteLine($"immutableArray[{immutableArray.IndexOf(item)}] = {item.Title}");
            }
            Console.WriteLine();
            #endregion         

            #region ImmutableList

            Console.WriteLine("--- ImmutableList ---");
            var list3 = new List<Movie>
            {
                new Movie {Id = 1, Title = "Title 1"},
                new Movie {Id = 2, Title = "Title 2"},
                new Movie {Id = 3, Title = "Title 3"},
            };
            var immutableList = list3.ToImmutableList();
            Console.WriteLine("immutableList:");
            foreach (var item in immutableList)
            {
                Console.WriteLine($"immutableList[{immutableList.IndexOf(item)}] = {item.Title}");
            }
            list3.Add(new Movie { Id = 4, Title = "Title 4" });
            Console.WriteLine();
            Console.WriteLine("immutableList after modifying underlying list:");
            foreach (var item in immutableList)
            {
                Console.WriteLine($"immutableList[{immutableList.IndexOf(item)}] = {item.Title}");
            }
            Console.WriteLine();
            #endregion

            #region ImmutableDictionary

            // Add System.Collections.Immutable package

            Console.WriteLine("--- ImmutableDictionary ---");
            var dictionary2 = new Dictionary<int, Movie>
            {
                {1, new Movie {Id = 1, Title = "Title 1"}},
                {2, new Movie {Id = 2, Title = "Title 2"}},
                {3, new Movie {Id = 3, Title = "Title 3"}},
            };
            var immutableDictionary = dictionary2.ToImmutableDictionary();
            Console.WriteLine("immutableDictionary:");
            foreach (var item in immutableDictionary)
            {
                Console.WriteLine($"immutableDictionary[{item.Key}] = {item.Value.Title}");
            }
            dictionary2.Add(4, new Movie { Id = 4, Title = "Title 4" });
            Console.WriteLine();
            Console.WriteLine("immutableDictionary after modifying underlying list:");
            foreach (var item in immutableDictionary)
            {
                Console.WriteLine($"immutableDictionary[{item.Key}] = {item.Value.Title}");
            }
            Console.WriteLine();
            #endregion

        }
    }
}
