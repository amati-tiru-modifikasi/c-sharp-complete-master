using System;
using System.Collections.Generic;
using System.Globalization;

namespace CharAndStringTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region char

            Console.WriteLine("---char---");

            //Initialization
            char char1 = 'C';
            char char2 = '\x0043';
            char char3 = '\u0043';
            char char4 = (char)67;

            Console.WriteLine($"{nameof(char1)} == {nameof(char2)} ? : {char1 == char2}");
            Console.WriteLine($"{nameof(char1)} == {nameof(char3)} ? : {char1 == char3}");
            Console.WriteLine($"{nameof(char1)} == {nameof(char4)} ? : {char1 == char4}");

            Console.WriteLine($"Is {nameof(char3)} a letter ? : {char.IsLetter(char3)}");

            // Concat
            Console.WriteLine(string.Concat("AB", char.ToString(char3)));
            
            //TryParse
            if (char.TryParse("C", out var char5))
            {
                Console.WriteLine("Parse succeeded");
                var list = new List<char>(){'A','B'};
                list.Add(char5);
                Console.WriteLine(list.ToArray());
            }
            else
            {
                Console.WriteLine("Parse failed");
            }

            #endregion

            #region string
            
            Console.WriteLine("---string---");
            // Reference type
            string string1 = null;
            // Initialization
            string1 = "I Love C# !  ";
            // Length property
            Console.WriteLine($"{nameof(string1)} Length : {string1.Length}");
            // ToUpper method
            Console.WriteLine($"{nameof(string1)} ToUpper() : {string1.ToUpper()}");
            // StartsWith method
            Console.WriteLine($"{nameof(string1)} StartsWith({'\u0049'}) ? : {string1.StartsWith('\u0049')}");
            // Trim method
            string string2 = string1.Trim();
            Console.WriteLine($"Length after Trim() of {nameof(string1)}: {string2.Length}");
            // Substring method
            string string3 = string1.Substring(0, string1.Length - 2);
            Console.WriteLine($"Length after Substring() of {nameof(string1)}: {string3.Length}");
            //Concat
            Console.WriteLine($"Concat : {string.Concat("AB","C")}");
            // Equality
            string string4 = "Hello";
            string string5 = "hello";
            Console.WriteLine($"{nameof(string4)} == {nameof(string5)} : {string4 == string5}");
            Console.WriteLine($"{nameof(string4)} == {nameof(string5)} : {string4.Equals(string5)}");
            Console.WriteLine($"{nameof(string4)} == {nameof(string5)} : {string.Equals(string4,string5)}");
            // Compare
            Console.WriteLine($"{nameof(string4)} > {nameof(string5)} : {string4.CompareTo(string5)}");
            Console.WriteLine($"{nameof(string4)} > {nameof(string5)} : {string.Compare(string4, string5)}");
            //Format
            string formatedString = string.Format("5 > 4 ? : {0}", 5 > 4);
            Console.WriteLine($"formatedString : {formatedString}");
            // Indexes
            Console.Write($"Letters in {nameof(string1)} : ");
            for (int i = 0; i < string1.Length; i++)
            {
                char charAtIndex = string1[i];
                if (char.IsLetter(charAtIndex))
                {
                    Console.Write($"{char.ToUpper(charAtIndex)}");
                }
            }
            // Strings are immutable
            string string6 = "   Trim this !  ";
            Console.WriteLine();
            Console.WriteLine($"{nameof(string6)} = {string6}");
            IncorrectTrim(string6);
            Console.WriteLine($"{nameof(string6)} after Incorrect Trim = {string6}");
            string6 = Trim(string6);
            Console.WriteLine($"{nameof(string6)} after Trim = {string6}");
            #endregion
        }

        internal static Country GetCountry(string isoCode)
        {
            if (string.IsNullOrEmpty(isoCode) || string.IsNullOrWhiteSpace(isoCode))
            {
                throw new ArgumentException("Code is null, empty or whitespace");
            }
            return new Country(){Id = 1, IsoCode = "ABC", Culture = CultureInfo.GetCultureInfo("en-US")};
        }

        static void IncorrectTrim(string word)
        {
            word.Trim();
        }

        static string Trim(string word)
        {
            return word.Trim();
        }
    }

    public class Country
    {
        public int Id { get; set; }
        public string IsoCode { get; set; }
        public CultureInfo Culture { get; set; }

    }
}
