using System;
using System.Collections.Generic;
using System.IO;

namespace CollectionsPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Stack ---");
            // declaration + instantiation
            var stack = new Stack<Movie>();
            // Push elements
            stack.Push(new Movie { Id = 1, Title = "Title 1" });
            stack.Push(new Movie { Id = 2, Title = "Title 2" });
            stack.Push(new Movie { Id = 3, Title = "Title 3" });
            stack.Push(new Movie { Id = 4, Title = "Title 4" });
            // Enumerate
            foreach (var element in stack)
            {
                Console.WriteLine($"Title : {element.Title}");
            }
            var topElement = stack.Peek();
            Console.WriteLine($"Peek element title : {topElement.Title}");
            // Pop
            Console.WriteLine("Stack1 Pop:");
            stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine($"{element.Title}");
            }
            var lastPush = stack.Peek();
            // push
            Console.WriteLine("Last pushed:");
            Console.WriteLine($"{lastPush.Title}");
            // Stack accepts duplicate elements
            var movie1 = new Movie { Id = 5, Title = "Title 5" };
            stack.Push(movie1);
            stack.Push(movie1);
            Console.WriteLine("Stack1 with duplicates:");
            foreach (var element in stack)
            {
                Console.WriteLine($"{element.Title}");
            }
        }
    }
}
