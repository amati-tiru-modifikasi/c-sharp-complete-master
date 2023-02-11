using System;

namespace Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;
            // boolean condition
            if (answer == true)
            {
                Console.WriteLine($"{nameof(answer)} is yes");
            }
            else
            {
                Console.WriteLine($"{nameof(answer)} is no");
            }
            // simplified boolean condition expression
            if (answer)
            {
                Console.WriteLine($"{nameof(answer)} is yes");
            }
            else
            {
                Console.WriteLine($"{nameof(answer)} is no");
            }
            // negation operator
            bool answerProvided = true;
            if (!answerProvided) // equivalent to if (answer == false)
            {
                Console.WriteLine("{No answer provided");
            }
            // ternary conditional operator, evaluates a boolean expression
            string message = answer ? $"{nameof(answer)} is yes" : $"{nameof(answer)} is no";
            Console.WriteLine(message);
            //another boolean expression (comparison)
            int numberOfAnswers = 7;
            message = numberOfAnswers > 5 ? "More than 5 answers" : "5 answers or less";
            Console.WriteLine(message);
            // Compare two booleans
            bool b1 = true;
            bool b2 = false;
            if (b1.Equals(b2)) // bool is a struct System.Boolean Equals method // equivalent to if (b1 == b2)
            {
                Console.WriteLine($"{nameof(b1)} and {nameof(b2)} are equal");
            }
            else
            {
                Console.WriteLine($"{nameof(b1)} and {nameof(b2)} are different");
            }
            // parse a boolean
            string str1 = "truE";
            string str2 = "true";
            string str3 = "TRUE";
            bool str1Parsed = bool.Parse(str1); // bool is a struct System.Boolean Parse static method
            bool str2Parsed = bool.Parse(str2);
            bool str3Parsed = bool.Parse(str3);
            if (str1Parsed == str2Parsed && str2Parsed == str3Parsed)
            {
                Console.WriteLine("These booleans are equal");
            }
            else
            {
                Console.WriteLine("These booleans are not equal");
            }
        }
    }
}
