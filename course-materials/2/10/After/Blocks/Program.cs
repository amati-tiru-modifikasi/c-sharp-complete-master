using System;

namespace Blocks
// Start of namespace block
{
    class Program
    // Start of class block
    {

        static void Main(string[] args)
        // Start of main method block
        {

            for (int i = 0; i < 10; i++)
            // Start of for block
            {
                // Start of if block
                if (Helper.IsEven(i))
                {
                    Console.WriteLine($"{i} is even");
                }
                // End of if block
                // Else block 
                else
                {
                    Console.WriteLine($"{i} is odd");
                }
                // End of else block
                
                // Could be written like this
                // Console.WriteLine(Helper.IsEven(i) ? $"{i} is even" : $"{i} is odd");
            }
            // End of for block
        }
        // End of main method block
    }
    // End of class block

    // class block

    internal static class Helper
    {
        internal static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
        
        internal static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
// End of namespace block



