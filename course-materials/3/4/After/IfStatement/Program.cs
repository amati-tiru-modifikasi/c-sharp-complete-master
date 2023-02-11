using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if...else

            var randomInt = new Random().Next();
            if (randomInt % 2 == 0)
            {
                Console.WriteLine($"The generated integer {randomInt} is even!");
            }
            else
            {
                Console.WriteLine($"The generated integer {randomInt} is odd!");

            }

            #endregion

            #region if...else without curly braces

            if (randomInt % 2 == 0)
                Console.WriteLine($"The generated integer {randomInt} is even!");
            else
                Console.WriteLine($"The generated integer {randomInt} is odd!");

            #endregion

            #region simple if
            //Divide(48,0); // Throws an exception
            int result = Divide(48,3);
            Console.WriteLine(result);
            #endregion

            #region if...else if

            if (randomInt % 2 == 0)
            {
                Console.WriteLine($"The generated integer {randomInt} is a multiple of 2!");
            }
            else if (randomInt % 3 == 0)
            {
                Console.WriteLine($"The generated integer {randomInt} is a multiple of 3!");

            }
            else if (randomInt % 5 == 0)
            {
                Console.WriteLine($"The generated integer {randomInt} is a multiple of 5!");

            }
            else if (randomInt % 7 == 0)
            {
                Console.WriteLine($"The generated integer {randomInt} is a multiple of 7!");

            }

            #endregion

        }

        static int Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException($"Denominator argument is invalid. Please provide a positive integer.");
            }
            return numerator/denominator;
        }


    }
}
