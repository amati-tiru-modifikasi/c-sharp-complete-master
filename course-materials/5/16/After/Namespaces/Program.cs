using System; // Don't have to import the System namespace to use its classes (fully qualified names)

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fully qualified names
            // System namespace
            // Console class
            // Method writeline
            System.Console.WriteLine("Hello World!");
            Console.WriteLine("I love C#!"); // error if using System; is commented
        }
    }
}
