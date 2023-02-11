using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.Concurrent;

namespace CollectionsAndCollectionInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic collections implement IEnumerable
            IEnumerable<int> list = new List<int>();
            IEnumerable<KeyValuePair<string, int>> dictionary = new Dictionary<string, int>();
            IEnumerable<int> stack = new Stack<int>();
            IEnumerable<int> linkedList = new LinkedList<int>();

            // Immutable install package
            // import the namespace System.Collections.Immutable
            IEnumerable<int> immutableList = ImmutableList.Create<int>();
            IEnumerable<KeyValuePair<string, int>> immutableDictionary = ImmutableDictionary.Create<string, int>();
            IEnumerable<int> immutableStack = ImmutableStack.Create<int>();

            // Import concurent collections namespace
            // to use concurent collections
            IEnumerable<KeyValuePair<string, int>> concurentDictionary = new ConcurrentDictionary<string, int>();

            list = new List<int> {1,2,3,4,5};
            foreach (var element in list)
            {
                Console.WriteLine($"element: {element}");
            }

            // elements can't be modified in a foreach
            // foreach (var element in list)
            // {
            //     element += 1;
            // }

        }
    }
}
