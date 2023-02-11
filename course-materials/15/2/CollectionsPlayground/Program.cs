using System;
using System.Collections.Generic;
using System.IO;

namespace CollectionsPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInt1 = new List<int>();
            listOfInt1.Add(1);
            listOfInt1.Add(2);
            listOfInt1.Add(3);
            listOfInt1.Add(4);
            listOfInt1.Add(5);

            var listOfInt2 = new List<int> { 1, 2, 3, 4, 5 };
            // List are zeo indexed
            Console.WriteLine($"listOfInt1[0] = {listOfInt1[0]}");
            // Number of elements
            Console.WriteLine($"listOfInt1.Count = {listOfInt1.Count}");
            // Look up
            var listElement = listOfInt1[0];
            // Add an element at the end of the list
            listOfInt2.Add(6);
            Console.WriteLine("listOfInt1.Add(6)");
            foreach (var element in listOfInt2)
            {
                Console.WriteLine($"Index [{listOfInt2.IndexOf(element)}] = {element}");
            }
            // Remove an element
            listOfInt2.Remove(1);
            Console.WriteLine("listOfInt1.Remove(1)");
            foreach (var element in listOfInt2)
            {
                Console.WriteLine($"Index [{listOfInt2.IndexOf(element)}] = {element}");
            }

            var movieList = new List<Movie>{
                new Movie{ Id = 1 , Title = "Title 1" },
                new Movie{ Id = 2 , Title = "Title 2" },
                new Movie{ Id = 3 , Title = "Title 3" }
            };
            movieList.Remove(movieList[0]);
            Console.WriteLine("movieList.Remove(movieList[0])");
            foreach (var element in movieList)
            {
                Console.WriteLine($"{element.Id} - {element.Title}");
            }

            // This does not work
            movieList.Remove(new Movie { Id = 3, Title = "Title 3" });
            Console.WriteLine("movieList.Remove(new Movie{ Id = 3 , Title = \"Title 3\" })");
            foreach (var element in movieList)
            {
                Console.WriteLine($"{element.Id} - {element.Title}");
            }
            // You have to pass the reference to the object that you want delete
            movieList.Remove(movieList[1]);
            Console.WriteLine("movieList.Remove(movieList[1])");
            foreach (var element in movieList)
            {
                Console.WriteLine($"{element.Id} - {element.Title}");
            }
            // RemoveAt() is faster than Remove(), because there is no need for an element lookup before the removal
            listOfInt2.RemoveAt(0);
            Console.WriteLine("listOfInt1.RemoveAt(0)");
            foreach (var element in listOfInt2)
            {
                Console.WriteLine($"Index [{listOfInt2.IndexOf(element)}] = {element}");
            }
            // Sort
            var listOfInt3 = new List<int> { 5, 2, 4, 3, 1 };
            listOfInt3.Sort();
            Console.WriteLine("listOfInt2.Sort()");
            foreach (var element in listOfInt3)
            {
                Console.WriteLine($"Index [{listOfInt3.IndexOf(element)}] = {element}");
            }
            var movieList2 = new List<Movie>{
                new Movie{ Id = 3 , Title = "Title 3" },
                new Movie{ Id = 1 , Title = "Title 1" },
                new Movie{ Id = 2 , Title = "Title 2" }
            };
            var movieComparer = new MovieComparer();
            movieList2.Sort(movieComparer);
            Console.WriteLine("movieList2.Sort(new MovieComparer())");
            foreach (var element in movieList2)
            {
                Console.WriteLine($"{element.Id} - {element.Title}");
            }

            // ArgumentOutOfRangeException
            // var outOfIndexElement = movieList2[6];
            
        }
    }
}
