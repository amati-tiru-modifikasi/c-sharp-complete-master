using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declaration for built in types

            // Boolean
            bool myBoolean = true;
            Console.WriteLine($"{nameof(myBoolean)} : {myBoolean}");
            // Char
            char myChar = 'a'; // '\u0061' or '\x0061'
            Console.WriteLine($"{nameof(myChar)} : {myChar}");
            // String
            string myString = "this is a string";
            Console.WriteLine($"{nameof(myString)} : {myString}");
            // Integer
            int myInteger = 7;
            Console.WriteLine($"{nameof(myInteger)} : {myInteger}");
            // Long
            long myLong = 1215465575654812337;
            Console.WriteLine($"{nameof(myLong)} : {myLong}");
            // Short
            short myShort = 4655;
            // Double
            Console.WriteLine($"{nameof(myShort)} : {myShort}");
            double myDouble = 2416165687451.221355d;
            // Float
            float myFloat = 3.4f;
            Console.WriteLine($"{nameof(myFloat)} : {myFloat}");
            // Decimal
            decimal amount = 20.170m;
            Console.WriteLine($"{nameof(amount)} : {amount}");
            // object
            object obj = myString;
            obj = amount;
            obj = myBoolean;

            #endregion

            #region declare and use a local variable

            DisplayMultiplesOf2And3();

            #endregion
 
            #region implicitly typed local variable

            var myVar = 1;
            myVar = myInteger;
            // myVar = myString; // Error
            myVar = myShort;
            // myVar = myDouble; // Error
            #endregion
        }

        static void DisplayMultiplesOf2And3()
        {
            // We declare a local counter variable of type 
            // int. Will store the number of elements that are 
            // multiples of 7 and 13
            int counter = 0;
            // We declare a local variable i that will be used
            // for looping from 1 to 1000 with an increment of 1
            for (int i = 0; i <= 1000; i++)
            {
                // If the remainders of i divided by 7 and 13 are equal to zero
                if (i % 7 == 0 && i % 13 == 0)
                {
                    /*
					i can be divided by 7 and 13
					write output a message for i
					increment counter
					*/
                    Console.WriteLine($"{i} is a multiple of 7 and 13");
                    counter++;
                }
            }
            // display counter
            Console.WriteLine($"Between 0 and 1000, we found {counter} numbers that are multiples of 7 and 13");
        }
    }
}
