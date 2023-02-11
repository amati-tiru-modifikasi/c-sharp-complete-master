using System;

namespace FloatingNumberTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region binary floating point numbers

            Console.WriteLine("---float---");

            Console.WriteLine($"float is allocated {sizeof(float)} bytes in memory");
            Console.WriteLine($"double is allocated {sizeof(double)} bytes in memory");

            // Float/Double declaration
            float f = 15.2f;
            double d = 15.2; // or 15.2d
            Console.WriteLine($"{f:G9}");
            Console.WriteLine($"{d:G17}");
            f = 157_854_675_996_545_616_565_465_616_465_616f;
            Console.WriteLine(f); // result 1.5785468E+32, have been rounded !!!
            f = 1E-45f;
            f = 1e-45f;
            // f = 0.25; // error
            f = 0.25f;
            Console.WriteLine($"{nameof(f)} = {f:G9}");
            // float is imprecise for some real numbers 
            f = 0.2f; // f is an approximation 0.2 in decimal ~ 0. 0011 0011 0011 0011 0011 0011 ... in binary
            Console.WriteLine($"{nameof(f)} = {f:G9}");
            // this the closest representation to 0.2

            Console.WriteLine($"Min Value for float : {float.MinValue}");
            Console.WriteLine($"Max Value for float : {float.MaxValue}");
            Console.WriteLine($"Min Value for double : {double.MinValue}");
            Console.WriteLine($"Max Value for double : {double.MaxValue}");

            float float3 = 0.1f;
            float3 += 0.000001f;
            float3 += 0.000001f;
            float3 += 0.000001f;
            float3 += 0.000001f;
            if (float3 == 0.100004f)
            {
                Console.WriteLine($"{float3:G9} Equal to {0.100004f:G9}");
            }
            else
            {
                Console.WriteLine($"{float3:G9} different from {0.100004f:G9}");
            }

            // Performing mathematical operations on floating-point values leads to a loss of precision
            float float1 = 0.25f;
            Console.WriteLine($"{nameof(float1)} = {float1:G9}");
            float sum1 = f + f;
            Console.WriteLine($"{nameof(float1)} + {nameof(float1)} = {sum1:G9}");
            sum1 = f + f + f;
            Console.WriteLine($"{nameof(float1)} + {nameof(float1)} + {nameof(float1)} = {sum1:G9}");
            float float2 = 0.20f;

            Console.WriteLine($"{nameof(float2)} = {float2:G9}");
            sum1 = float2 + float2;
            Console.WriteLine($"{nameof(float2)} + {nameof(float2)} = {sum1:G9}");
            sum1 = float2 + float2 + float2;
            Console.WriteLine($"{nameof(float2)} + {nameof(float2)} + {nameof(float2)} = {sum1:G9}");

            // Performing mathematical operations on floating-point values leads to less precision  
            double double1 = 0.25;
            Console.WriteLine($"{nameof(d)} = {d:G17}");
            double sum2 = double1 + double1;
            Console.WriteLine($"{nameof(double1)} + {nameof(double1)} = {sum2:G17}");
            sum2 = double1 + double1 + double1;
            Console.WriteLine($"{nameof(double1)} + {nameof(double1)} + {nameof(double1)} = {sum2:G17}");

            double double2 = 0.20;
            // f2 is an approximation 0.2 in decimal ~ 0. 0011 0011 0011 0011 0011 0011 ... in binary
            Console.WriteLine($"{nameof(double2)} = {double2:G17}");
            sum2 = double2 + double2;
            Console.WriteLine($"{nameof(double2)} + {nameof(double2)} = {sum2:G17}");
            sum2 = double2 + double2 + double2;
            Console.WriteLine($"{nameof(double2)} + {nameof(double2)} + {nameof(double2)} = {sum2:G17}");

            // Nan, Infinity
            double nan = double.NaN;
            double posInfinity = double.PositiveInfinity;
            double negInfinity = double.NegativeInfinity;
            // float.Epsilon Represents the smallest positive value that is greater than zero
            Console.WriteLine($"Epsilon = {float.Epsilon}");
            Console.WriteLine($"Epsilon = {double.Epsilon}");

            // We can't represent large numbers with a large precision, limited number of digits
            float float4 = 123456f;
            float tinyFloat = 1e-3f; // float.Epsilon Represents the smallest positive value that is greater than zero
            Console.WriteLine($"{nameof(float4)} = {float4:G9}");
            Console.WriteLine($"{nameof(tinyFloat)} = {tinyFloat:G9}");
            Console.WriteLine($"{nameof(float4)} + {nameof(tinyFloat)} = {float4 + tinyFloat:G9}");
            // We can't represent large numbers with a large precision, limited number of digits
            double double3 = 123456789;
            double tinyDouble = 1e-7;
            Console.WriteLine($"{nameof(double3)} = {double3:G17}");
            Console.WriteLine($"{nameof(tinyDouble)} = {tinyDouble}");
            Console.WriteLine($"{nameof(double3)} + {nameof(tinyDouble)} = {double3 + tinyDouble}");

            // Compare
            Console.WriteLine($"{nameof(float1)} > {nameof(float2)} ? {float1.CompareTo(float2)}");
            double d1 = 1.58751e110;
            double d2 = 1.2545845e110;
            string yesOrNo = d1.CompareTo(d2) > 0 ? "yes" : "no";
            Console.WriteLine($"{nameof(d1)} > {nameof(d2)} ? {yesOrNo}");

            #endregion

            #region decimal floating point numbers

            Console.WriteLine("---decimal---");

            Console.WriteLine($"decimal is allocated {sizeof(decimal)} bytes in memory");

            Console.WriteLine($"Min Value for decimal : {decimal.MinValue}");
            Console.WriteLine($"Max Value for decimal : {decimal.MaxValue}");


            decimal dividend = 1m;
            decimal divisor = 3m;
            Console.WriteLine($"1mx3m/3m = {dividend / divisor * divisor}");
            Console.WriteLine($"1m/3m = {1m / 3m}");
            decimal decimal1 = 1m / 3m;
            Console.WriteLine($"{nameof(decimal1)} = {decimal1:G29}");

            decimal tinyDecimal = 1e-28m;
            Console.WriteLine($"{nameof(tinyDecimal)} = {tinyDecimal:G29}");
            decimal1 = 1m + tinyDecimal;
            Console.WriteLine($"{nameof(decimal1)} = {decimal1:G29}");

            tinyDecimal = 1e-18m;
            Console.WriteLine($"{nameof(tinyDecimal)} = {tinyDecimal:G29}");
            decimal1 = 1e10m + tinyDecimal;
            Console.WriteLine($"{nameof(decimal1)} = {decimal1:G29}");

            tinyDecimal = 1e-8m;
            Console.WriteLine($"{nameof(tinyDecimal)} = {tinyDecimal:G29}");
            decimal1 = 1e20m + tinyDecimal;
            Console.WriteLine($"{nameof(decimal1)} = {decimal1:G29}");

            // Add 2 decimals
            var decimal2 = decimal.Add(10.2m, 24.5m);
            Console.WriteLine($"{nameof(decimal1)} : {decimal1}");

            // Compare
            decimal1 = dividend / divisor * divisor;
            decimal one = Decimal.One;
            string isGreaterThan = one.CompareTo(decimal1) > 0 ? "yes" : "no";
            Console.WriteLine($"{nameof(decimal1)} = {decimal1:G29}");
            Console.WriteLine($"{nameof(one)} = {one:G29}");
            Console.WriteLine($"{nameof(one)} > {nameof(decimal1)} ? {isGreaterThan}");

            // Round
            decimal1 = Decimal.Round(dividend / divisor * divisor);
            string areEqual = one.Equals(decimal1) ? "yes" : "no";
            Console.WriteLine($"{nameof(decimal1)} = {decimal1:G29}");
            Console.WriteLine($"{nameof(one)} = {one:G29}");
            Console.WriteLine($"{nameof(one)} = {nameof(decimal1)} ? {areEqual}");

            #endregion

        }
    }
}
