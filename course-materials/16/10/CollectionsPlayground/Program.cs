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
            //Other();
            // RunLinkedListExamples();
            // RunSortedDictionaryExamples();
            RunReadOnlyCollectionsExamples();

        }

        private static void RunLinkedListExamples()
        {
            Console.WriteLine("--- LinkedList ---");

            var linkedList = new LinkedList<Movie>();
            linkedList.AddLast(new Movie { Id = 2, Title = "Title 2" });
            linkedList.AddLast(new Movie { Id = 3, Title = "Title 3" });
            linkedList.AddLast(new Movie { Id = 4, Title = "Title 4" });
            linkedList.AddFirst(new Movie { Id = 1, Title = "Title 1" });
            Console.WriteLine("linkedList:");
            foreach (var item in linkedList)
            {
                Console.WriteLine($"{item.Title}");
            }

            linkedList.RemoveLast();
            Console.WriteLine("linkedList after RemoveLast:");
            foreach (var item in linkedList)
            {
                Console.WriteLine($"{item.Title}");
            }

            linkedList.RemoveFirst();
            Console.WriteLine("linkedList after RemoveFirst:");
            foreach (var item in linkedList)
            {
                Console.WriteLine($"{item.Title}");
            }

            Console.WriteLine("linkedList after RemoveFirst:");
            var linkedListNode = linkedList.First;
            foreach (var item in linkedList)
            {
                Console.WriteLine($"{item.Title}");
            }
            linkedList.AddBefore(linkedListNode, new Movie { Id = 1, Title = "Title 1" });
            Console.WriteLine("linkedList after AddBefore:");
            foreach (var item in linkedList)
            {
                Console.WriteLine($"{item.Title}");
            }

            linkedListNode = linkedList.Last;
            linkedList.AddAfter(linkedListNode, new Movie { Id = 5, Title = "Title 5" });
            Console.WriteLine("linkedList after AddAfter:");
            foreach (var item in linkedList)
            {
                Console.WriteLine($"{item.Title}");
            }

            linkedListNode = linkedList.Last.Previous;
            linkedList.Remove(linkedListNode);
            Console.WriteLine("linkedList after Remove:");
            foreach (var item in linkedList)
            {
                Console.WriteLine($"{item.Title}");
            }
            Console.WriteLine();
        }

        private static void Other()
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

        private static void RunReadOnlyCollectionsExamples()
        {
            #region ReadOnlyCollections

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

            #endregion

            #region ReadOnlyDictionary

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
            #endregion
        }

        private static void RunSortedDictionaryExamples()
        {
            Console.WriteLine("--- SortedDictionary ---");
            var dictionary1 = new Dictionary<int, Movie>
            {
                {3, new Movie {Id = 3, Title = "Title 3"}},
                {1, new Movie {Id = 1, Title = "Title 1"}},
                {2, new Movie {Id = 2, Title = "Title 2"}}
            };
            var sortedDictionary1 = new SortedDictionary<int, Movie>(dictionary1);
            Console.WriteLine("sortedDictionary1:");
            foreach (var item in dictionary1)
            {
                Console.WriteLine($"dictionary1[{item.Key}] = {item.Value.Title}");
            }
            // elements are sorted by key
            foreach (var item in sortedDictionary1)
            {
                Console.WriteLine($"sortedDictionary1[{item.Key}] = {item.Value.Title}");
            }

            var dictionary4 = new Dictionary<string, Movie>
            {
                {"Zorro", new Movie {Id = 1, Title = "Zorro"}},
                {"Avengers", new Movie {Id = 2, Title = "Avengers"}},
                {"Superman", new Movie {Id = 3, Title = "Superman"}},
            };
            var sortedDictionary2 = new SortedDictionary<string, Movie>(dictionary4);
            Console.WriteLine("sortedDictionary2:");
            foreach (var item in sortedDictionary2)
            {
                Console.WriteLine($"sortedDictionary2[{item.Key}] = {item.Value.Title}");
            }
        }
    }
}
