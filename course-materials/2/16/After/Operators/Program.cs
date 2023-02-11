using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arithmetic operators
            
            Console.WriteLine("Arithmetic operators");
            Console.WriteLine("Arithmetic operators : i++");
            
            int i = 0;
            int j = 0;
            Console.WriteLine(i);
            Console.WriteLine(j);
            j = i++;
            Console.WriteLine(i);
            Console.WriteLine(j);
            
            Console.WriteLine("Arithmetic operators : ++i");
            i = 0;
            j = 0;
            Console.WriteLine(i);
            Console.WriteLine(j);
            j = ++i;
            Console.WriteLine(i);
            Console.WriteLine(j);
            
            
            Console.WriteLine("Arithmetic operators : i--");
            i = 1;
            j = 1;
            Console.WriteLine(i);
            Console.WriteLine(j);
            j = i--;
            Console.WriteLine(i);
            Console.WriteLine(j);
            
            Console.WriteLine("Arithmetic operators : --i");
            i = 1;
            j = 1;
            Console.WriteLine(i);
            Console.WriteLine(j);
            j = --i;
            Console.WriteLine(i);
            Console.WriteLine(j);
            
            Console.WriteLine("Arithmetic operators : addition");
            var addition1 = 10 + 5;
            Console.WriteLine(addition1);
            
            var addition2 = 10f + 5;
            Console.WriteLine(addition2);
            
            var addition3 = 10m + 5.3m;
            Console.WriteLine(addition3);
            
            Console.WriteLine("Arithmetic operators : substraction");
            var substract1 = 10 - 5;
            Console.WriteLine(substract1);
            
            var substract2 = 10f - 5;
            Console.WriteLine(substract2);
            
            var substract3 = 10m - 5.3m;
            Console.WriteLine(substract3);
            
            Console.WriteLine("Arithmetic operators : multiplication");
            var multip1 = 10 * 5;
            Console.WriteLine(multip1);
            
            var multip2 = 10f * 5;
            Console.WriteLine(multip2);
            
            var multip3 = 10m * 5.3m;
            Console.WriteLine(multip3);
            
            Console.WriteLine("Arithmetic operators : division");
            var div1 = 10 - 5;
            Console.WriteLine(div1);
            
            var div2 = 10f - 5;
            Console.WriteLine(div2);
            
            var div3 = 10m - 5.3m;
            Console.WriteLine(div3);
            
            Console.WriteLine("Arithmetic operators : remainder");
            var modulo1 = 10 % 5;
            Console.WriteLine(modulo1);
            
            var modulo2 = 11 % 5;
            Console.WriteLine(modulo2);
            
            var modulo3 = 12 % 5;
            Console.WriteLine(modulo3);
            
            #endregion
            
            #region Comparison operators
            
            Console.WriteLine("Comparison operators");
            int int1 = 1;
            int int2 = 5;
            Console.WriteLine($"{nameof(int1)} > {nameof(int2)} ? : {int1 > int2}");
            
            int1 = 10;
            int2 = 10;
            Console.WriteLine($"{nameof(int1)} <= {nameof(int2)} ? : {int1 <= int2}");
            
            
            #endregion
            
            #region Equality operators
            
            Console.WriteLine("Equality operators");
            Console.WriteLine($"{nameof(int1)} == {nameof(int2)} ? : {int1 == int2}");
            string str1 = "I love C#";
            string str2 = "I Love C#";
            Console.WriteLine($"{nameof(str1)} == {nameof(str2)} ? : {str1 == str2}");
            Console.WriteLine($"{nameof(str1)} == {nameof(str2)} ({nameof(str1.ToLower)}) ? : {str1.ToLower() == str2.ToLower()}");
            
            #endregion

            #region Logical operators

            Console.WriteLine("Logical operators");
            
            bool bool1 = true;
            bool bool2 = false;
            bool bool3 = true;
            
            Console.WriteLine($"{nameof(bool1)} : {bool1}");
            Console.WriteLine($"{nameof(bool2)} : {bool2}");
            Console.WriteLine($"{nameof(bool3)} : {bool3}");
            Console.WriteLine($"!{nameof(bool1)} : {!bool1}");
            Console.WriteLine($"{nameof(bool1)} || {nameof(bool2) } || {nameof(bool3) }: {bool1 || bool2 || bool3}");
            Console.WriteLine($"{nameof(bool1)} ^ {nameof(bool2) } ^ {nameof(bool3) }: {bool1 ^ bool2 ^ bool3}");
            Console.WriteLine($"{nameof(bool1)} && {nameof(bool2) } && {nameof(bool3) }: {bool1 && bool2 && bool3}");

            #endregion

            #region string concatenation

            string string1 = string.Empty;
            string1 = "Hello " + "World";
            
            string string2 = string1 + "!";
            Console.WriteLine($"{nameof(string1)} : {string1}");
            Console.WriteLine($"{nameof(string2)} : {string2}");

            #endregion

            #region += operator

            // string concatenation
            string string3 = "Hello World";
            string3 += "!"; // string3 = string3 + "!";
            Console.WriteLine($"{nameof(string3)} : {string3}");

            // on integer
            int int5 = 0;
            int5 += 10; // int5 = int5 + 10;
            Console.WriteLine($"{nameof(int5)} : {int5}");

            #endregion
        }
    }
}
