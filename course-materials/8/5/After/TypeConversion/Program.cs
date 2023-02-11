using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // explicit conversions 
            // numeric conversions

            int int1 = 100;
            // cast
            sbyte sbyte1 = (sbyte)int1;
            Console.WriteLine($"{nameof(sbyte1)} = {sbyte1}");

            short short1 = 200;
            ulong ulong1 = (ulong)short1;
            Console.WriteLine($"{nameof(ulong1)} = {ulong1}");


            // Enumeration conversion
            Planet planet = 0;
            Console.WriteLine($"{nameof(planet)} : {planet}");
            ushort ushort1 = 1;
            planet = (Planet)ushort1;


            // Unboxing
            object obj1 = short1;
            short short2 = (short)obj1;
            Console.WriteLine($"{nameof(short2)} = {short2}");

            object obj2 = 10;
            int i1 = (int)obj2;


            // throws InvalidCastException
            // object obj = '\x0043';
            // string string1 = (string)obj;

            // reference conversions
            var baseInstance = new BaseClass();
            DerivedClass derivedInstance = (DerivedClass)baseInstance; //throws an InvalidCastException, use the as operator

            // anonymous type
            var movie = new { Id = 1, Title = "Title" };
            // compiling error
            // movie = new { Id = 1, Title = "Title", Overview = "" };
        }
    }

    class BaseClass
    {

    }

    class DerivedClass : BaseClass
    {

    }

    enum Planet
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }
}
