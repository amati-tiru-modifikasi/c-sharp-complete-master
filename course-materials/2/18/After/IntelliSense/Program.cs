using System;

namespace IntelliSense
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "I love C#";
            Console.WriteLine($"{myString.StartsWith("\x0049")}");
            Console.WriteLine($"{myString.Length}");
        }
    }
}
