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
 }
}
