using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // numeric conversions
            // allowed implicit conversions 
            sbyte sbyte1 = 100;
            short short1 = sbyte1;
            float float1 = sbyte1;
            float1 = short1;
            double double1 = float1;

            // Any integral type is convertible to any floating point type
            long long1 = 5000000000000000000;
            float1 = long1;

            Console.WriteLine($"{nameof(double1)} = {double1}");
            Console.WriteLine($"{nameof(float1)} = {float1}");

            // no implicit conversion to byte and sbyte
            // int int1 = 100;
            // sbyte1 = int1; // compilation error

            // reference conversions
            var baseInstance = new DerivedClass();
            BaseClass derivedInstance = baseInstance;

            var array = new int[3];
            Object obj1 = array;

            // Enumeration conversion
            Planet planet = 0;
            Console.WriteLine($"{nameof(planet)} : {planet}");

            // Boxing
            obj1 = short1;
            int i = 10;
            object obj2 = i;
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
