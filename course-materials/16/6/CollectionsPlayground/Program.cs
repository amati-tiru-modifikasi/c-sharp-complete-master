using System;
using System.Collections.Generic;
using System.IO;

namespace CollectionsPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration
            Console.WriteLine("--- HashSet ---");
            var hashset1 = new HashSet<int>();
            var hashset2 = new HashSet<int>();
            // Add elements
            for (int i = 0; i < 5; i++)
            {
                hashset1.Add(i);
                hashset2.Add(i * 2);
            }
            Console.WriteLine("hashset1");
            foreach (var element in hashset1)
            {
                Console.WriteLine($"{element}");
            }
            Console.WriteLine("hashset2");
            foreach (var element in hashset2)
            {
                Console.WriteLine($"{element}");
            }
            // Intersect
            var intersectHashSet = new HashSet<int>(hashset1);
            intersectHashSet.IntersectWith(hashset2);
            Console.WriteLine("hashset1 intersect hashset2");
            foreach (var element in intersectHashSet)
            {
                Console.WriteLine($"{element}");
            }
            // Union
            var unionHashSet = new HashSet<int>(hashset1);
            unionHashSet.UnionWith(hashset2);
            Console.WriteLine("hashset1 union hashset2");
            foreach (var element in unionHashSet)
            {
                Console.WriteLine($"{element}");
            }
            // Hashset ignores duplicates
            hashset1.Add(0);
            Console.WriteLine("hashset1 ignores duplicates");
            foreach (var element in hashset1)
            {
                Console.WriteLine($"{element}");
            }

            // HashSet<Movie> hashSet = new HashSet<Movie>();
            HashSet<Movie> hashSet = new HashSet<Movie>(new MovieEqualityComparer());
            // var movie = new Movie{ Id = 2 , Title = "Title 2" };
            hashSet.Add(new Movie{ Id = 1 , Title = "Title 1" });
            hashSet.Add(new Movie{ Id = 2 , Title = "Title 2" });
            hashSet.Add(new Movie{ Id = 2 , Title = "Title 2" });

            foreach (var element in hashSet)
            {
                Console.WriteLine($"{element.Id} - {element.Title}");
            }
        }

    }
}
