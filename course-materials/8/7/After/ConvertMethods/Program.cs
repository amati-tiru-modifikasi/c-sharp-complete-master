using System;

namespace ConvertMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SuccessfullConversions();
            ConversionDoubleToFloat();
            ConversionsWithFormatException();
            ConversionsWithOverflowException1();
            ConversionsWithOverflowException2();
            ConversionsWithInvalidCastException();
        }

        private static void SuccessfullConversions()
        {
            // conversion ok
            string str = "10";
            int i = Convert.ToInt32(str);
            Console.WriteLine($"{nameof(i)} = {i}");
            short s = 100;
            double d = Convert.ToDouble(s);
            Console.WriteLine($"{nameof(d)} = {d}");
            int j = 2;
            bool b = Convert.ToBoolean(j);
            Console.WriteLine($"{nameof(b)} = {b}");
        }
        private static void ConversionsWithFormatException()
        {
            // this initialization generates an 
            // Unhandled exception. System.FormatException: Input string was not in a correct format
            string str = "10.45";
            int i = Convert.ToInt32(str);
            Console.WriteLine($"{nameof(i)} = {i}");
        }
        private static void ConversionDoubleToFloat()
        {
            double d = 1e30;
            // double d = 1e40;
            float f = Convert.ToSingle(d);
            Console.WriteLine($"{nameof(f)} = {f}");
        }
        private static void ConversionsWithOverflowException()
        {
            // this initialization generates an 
            // Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32
            long l = 9_223_372_036_854_775_807;
            int i = Convert.ToInt32(l);
            Console.WriteLine($"{nameof(i)} = {i}");
            // this initialization generates an 
            // Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32
            float f = float.MaxValue;
            i = Convert.ToInt32(f);
            Console.WriteLine($"{nameof(i)} = {i}");
        }
        private static void ConversionsWithInvalidCastException()
        {
            // this initialization generates an 
            // Unhandled exception. System.InvalidCastException: Invalid cast from 'Char' to 'Boolean'
            char c = 'a';
            bool b = Convert.ToBoolean(c);
            Console.WriteLine($"{nameof(b)} = {b}");
        }
    }
}
