using System;
using System.Collections.Generic;
using System.IO;

namespace CollectionsPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Queue ---");
            var queue = new Queue<Movie>();
            queue.Enqueue(new Movie { Id = 1, Title = "Title 1" });
            queue.Enqueue(new Movie { Id = 2, Title = "Title 2" });
            queue.Enqueue(new Movie { Id = 3, Title = "Title 3" });
            queue.Enqueue(new Movie { Id = 4, Title = "Title 4" });
            // iterate
            Console.WriteLine("Queue1 :");
            foreach (var element in queue)
            {
                Console.WriteLine($"{element.Title}");
            }
            Console.WriteLine("Queue1 Dequeue:");
            queue.Dequeue();
            foreach (var element in queue)
            {
                Console.WriteLine($"{element.Title}");
            }
            var firstEnqueued = queue.Peek();
            Console.WriteLine("First enqueued:");
            Console.WriteLine($"{firstEnqueued.Title}");
            // Queue accepts duplicate elements
            var movie1 = new Movie { Id = 5, Title = "Title 5" };
            queue.Enqueue(movie1);
            queue.Enqueue(movie1);
            Console.WriteLine("Queue1 with duplicates:");
            foreach (var element in queue)
            {
                Console.WriteLine($"{element.Title}");
            }
        }

    }
}
