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
            // List<int> list = new();
            // Dictionary<int, string> dictionary = new();

            ICollection<int> list = new List<int>();
            ICollection<KeyValuePair<int, string>> dictionary = new Dictionary<int, string>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            foreach (var element in list)
            {
                Console.WriteLine($"element : {element}");
            }
            dictionary.Add(new KeyValuePair<int, string>(1, "first"));
            ((Dictionary<int, string>)dictionary).Add(2, "second");
            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                Console.WriteLine($"KeyValuePair : {pair}");
            }
        }
    }
}
