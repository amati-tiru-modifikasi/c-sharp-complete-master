using System;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a line of characters to the console
            Console.WriteLine("Hello World!");
            // with string interpolation
            string str1 = "Hello World!";
            Console.WriteLine($"{str1}");

            // with an int
            int i = 10;
            Console.WriteLine($"{i}");

            // read a line from input
            Console.WriteLine("What's your name ?");
            string name1 = Console.ReadLine();
            Console.WriteLine($"Hello {name1}");

            // or
            Console.WriteLine("What's your name ?");
            string name2 = Console.ReadLine();
            string message = $"Hello {name2}";
            Console.WriteLine(message);

            // Get the window size
            int height = Console.WindowHeight;
            int width = Console.WindowWidth;

            Console.WriteLine($"Window height {height} - Window width {width}");

            // Set window size
            Console.SetWindowSize(200, 80);
        }
    }
}
