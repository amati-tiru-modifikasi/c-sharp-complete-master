using System;

namespace Statements
{

    class Program
    {
        static void Main(string[] args)
        {

            #region simple line statements
            // Simple line statements


            // Variable declaration statement
            string firstString;

            // Variable assignment statement
            firstString = "some string";
            Console.WriteLine($"{nameof(firstString)} : {firstString}");

            // Variable declaration and assignment in one statement
            string secondString = "another string";
            Console.WriteLine($"{nameof(secondString)} : {secondString}");

            Console.Write("PrintSomething method call : ");
            // Method call statement
            PrintSomething();

            // Variable declaration, initialization and method call in one statement
            int result = Square(4);

            Console.WriteLine($"{nameof(result)} : {result}");

            #endregion

            #region multiple lines statements
            // Multiple line statements

            Console.WriteLine($"{nameof(result)} = 16 ?");
            // If statement
            if (result == 16)
            {
                // Method call statement inside the top if statement
                Console.WriteLine("Good guess :)");
            }
            else
            {
                Console.WriteLine("Bad answer :/");
            }
            // Can be written with the ?: operator
            // Console.WriteLine(result == 8 ? "Good guess :)" : "Bad answer :/");

            Console.WriteLine("Square method call in a for loop");
            for (int i = 0; i < 10; i++)
            {
                // Method call statements inside of top for statement
                Console.WriteLine($"{i} squared equals {Square(i)}");
            }

            // Array declaration statement
            int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Square method call in a foreach loop");
            // Foreach statement
            foreach (var element in array)
            {
                // Method call statements inside of top foreach statement
                Console.WriteLine($"{element} squared equals {Square(element)}");
            }
            #endregion
        }

        static void PrintSomething()
        {
            Console.WriteLine("Hello from PrintSomething method!");
        }

        static int Square(int value)
        {
            // Return statement
            return value * value;
        }
    }
}
