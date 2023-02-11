using System;
using System.Collections.Generic;
using System.IO;

namespace CollectionsPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Arrays ---");

            // Declaration
            int[] integerArray;

            // Initialization
            integerArray = new int[3];

            // Multidimensional array
            int[,] multidimensionalArray = new int[3, 2];

            // You can instantiate the array when you declare it
            int[] integerArray2 = new int[3];

            // Array are reference type
            integerArray = null;

            integerArray = new int[5];

            // Default element values + Arrays are zero indexed
            // Array elements are initialized to their default values
            Console.WriteLine("Before array init");
            for (int i = 0; i < integerArray.Length; i++)
            {
                // Look up
                Console.WriteLine($"integerArray[{i}] = {integerArray[i]}");
            }

            // Modify element
            for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = new Random().Next(0, 10);
            }

            // Arrays are zero indexed
            Console.WriteLine("After array init");
            for (int i = 0; i < integerArray.Length; i++)
            {
                // Look up
                Console.WriteLine($"integerArray[{i}] = {integerArray[i]}");
            }


            Console.WriteLine();
            Console.WriteLine("Foreach");
            foreach (var arrayElement in integerArray)
            {
                Console.WriteLine($"integerArray[{Array.IndexOf(integerArray, arrayElement)}] = {arrayElement}");
            }

            // Number of elements can be defined at runtime
            var randomInt = new Random().Next(0, 10);
            integerArray = new int[randomInt];
            Console.WriteLine($"integerArray contains {integerArray.Length} elements");

            // Initialization
            int[] integerArray3 = { 1, 2, 3, 4, 4 }; // not posible with implicit typing (var)
            int[] integerArray4;
            // integerArray4 = {1, 2, 3, 4, 5}; // not possible when declaration and instanciaton are not in a single line
            integerArray4 = new int[5] { 1, 2, 3, 4, 5 };

            // Array abstract class, Go to the Array class definition

            // IndexOf, LastIndexOf static methods
            var indexOf4 = Array.IndexOf(integerArray3, 4);
            var lastIndexOf4 = Array.LastIndexOf(integerArray3, 4);
            Console.WriteLine($"{nameof(indexOf4)} = {indexOf4}");
            Console.WriteLine($"{nameof(lastIndexOf4)} = {lastIndexOf4}");

            // Reverse
            int[] integerArray5 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Reverse :");
            Array.Reverse(integerArray5);
            for (int i = 0; i < integerArray5.Length; i++)
            {
                Console.WriteLine($"integerArray4[{i}] = {integerArray5[i]}");
            }

            // Sort 
            Console.WriteLine("Sort :");
            Array.Sort(integerArray5);
            for (int i = 0; i < integerArray5.Length; i++)
            {
                Console.WriteLine($"integerArray4[{i}] = {integerArray5[i]}");
            }
        }
    }
}
