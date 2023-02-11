using System;

namespace IntegersTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 8 bits

            Console.WriteLine($"---sbyte---");
            
            Console.WriteLine($"sbyte is allocated {sizeof(sbyte)} bytes in memory");

            sbyte sbyte1 = -100;
            // sbyte sb1 = -150; //error
            // sbyte sb1 = 450; //error
            Console.WriteLine($"Min Value for sbyte : {sbyte.MinValue}");
            Console.WriteLine($"Max Value for sbyte : {sbyte.MaxValue}");

            sbyte sbyte2 = -0x64;
            sbyte sbyte3 = -0b_0110_0100;

            Console.WriteLine($"{nameof(sbyte1)} == {nameof(sbyte2)} : {sbyte1 == sbyte2}");
            Console.WriteLine($"{nameof(sbyte2)} == {nameof(sbyte3)} : {sbyte2 == sbyte3}");

            Console.WriteLine($"---byte---");
            
            Console.WriteLine($"byte is allocated {sizeof(byte)} bytes in memory");
            
            byte byte1 = 100;
            // byte b1 = 500; //error
            Console.WriteLine($"Min Value for byte : {byte.MinValue}");
            Console.WriteLine($"Max Value for byte : {byte.MaxValue}");

            byte byte2 = 0x64;
            byte byte3 = 0b_0110_0100;

            Console.WriteLine($"{nameof(byte1)} == {nameof(byte2)} : {byte1 == byte2}");
            Console.WriteLine($"{nameof(byte2)} == {nameof(byte3)} : {byte2 == byte3}");

            #endregion

            #region 16 bits

            Console.WriteLine($"---short---");
            
            Console.WriteLine($"short is allocated {sizeof(short)} bytes in memory");
            
            short short1 = -10000;
            // short short1 = 45000; //error
            Console.WriteLine($"Min Value for short : {short.MinValue}");
            Console.WriteLine($"Max Value for short : {short.MaxValue}");

            short short2 = -0x2710;
            short short3 = -0b_0010_0111_0001_0000;

            Console.WriteLine($"{nameof(short1)} == {nameof(short2)} : {short1 == short2}");
            Console.WriteLine($"{nameof(short2)} == {nameof(short3)} : {short2 == short3}");

            Console.WriteLine($"---ushort---");
            
            Console.WriteLine($"ushort is allocated {sizeof(ushort)} bytes in memory");

            ushort ushort1 = 24510;
            // ushort ushort1 = -150; //error
            // ushort ushort1 = 45000; //error
            Console.WriteLine($"Min Value for ushort : {ushort.MinValue}");
            Console.WriteLine($"Max Value for ushort : {ushort.MaxValue}");

            ushort ushort2 = 0x5FBE;
            ushort ushort3 = 0b_00101_1111_1011_1110;

            Console.WriteLine($"{nameof(ushort1)} == {nameof(ushort2)} : {ushort1 == ushort2}");
            Console.WriteLine($"{nameof(ushort2)} == {nameof(ushort3)} : {ushort2 == ushort3}");

            #endregion

            #region 32 bits

            Console.WriteLine($"---int---");
            
            Console.WriteLine($"int is allocated {sizeof(int)} bytes in memory");

            int int1 = -300_000_000;
            // int int1 = 450000000000; //error
            Console.WriteLine($"Min Value for int : {int.MinValue}");
            Console.WriteLine($"Max Value for int : {int.MaxValue}");

            int int2 = -0x11E1A300;
            int int3 = -0b_0001_0001_1110_0001_1010_0011_0000_0000;

            Console.WriteLine($"{nameof(int1)} == {nameof(int2)} : {int1 == int2}");
            Console.WriteLine($"{nameof(int2)} == {nameof(int3)} : {int2 == int3}");

            Console.WriteLine($"---uint---");
            
            Console.WriteLine($"uint is allocated {sizeof(uint)} bytes in memory");

            uint uint1 = 300_000_000;
            // uint uint1 = -150; //error
            // uint uint1 = 450000000000; //error
            Console.WriteLine($"Min Value for uint : {uint.MinValue}");
            Console.WriteLine($"Max Value for uint : {uint.MaxValue}");

            uint uint2 = 0x11E1A300;
            uint uint3 = 0b_0001_0001_1110_0001_1010_0011_0000_0000;

            Console.WriteLine($"{nameof(uint1)} == {nameof(uint2)} : {uint1 == uint2}");
            Console.WriteLine($"{nameof(uint2)} == {nameof(uint3)} : {uint2 == uint3}");

            #endregion

            #region 64 bits

            Console.WriteLine($"---long---");
            
            Console.WriteLine($"long is allocated {sizeof(long)} bytes in memory");
            
            long long1 = -9_128_371_036_844_175_808;
            //long long1 = 45000000000000000000000; //error
            Console.WriteLine($"Min Value for long : {long.MinValue}");
            Console.WriteLine($"Max Value for long : {long.MaxValue}");

            long long2 = -0x7EAE7D18050FB1C0;
            long long3 = -0b_0111_1110_1010_1110_0111_1101_0001_1000_0000_0101_0000_1111_1011_0001_1100_0000;

            Console.WriteLine($"{nameof(long1)} == {nameof(long2)} : {long1 == long2}");
            Console.WriteLine($"{nameof(long2)} == {nameof(long3)} : {long2 == long3}");

            Console.WriteLine($"---ulong---");
            
            Console.WriteLine($"ulong is allocated {sizeof(ulong)} bytes in memory");
            
            ulong ulong1 = 9_128_371_036_844_175_808;
            // ulong ulong1 = -150; //error
            // ulong ulong1 = 45000000000000000000000; //error
            Console.WriteLine($"Min Value for ulong : {ulong.MinValue}");
            Console.WriteLine($"Max Value for ulong : {ulong.MaxValue}");

            ulong ulong2 = 0x7EAE7D18050FB1C0;
            ulong ulong3 = 0b_0111_1110_1010_1110_0111_1101_0001_1000_0000_0101_0000_1111_1011_0001_1100_0000;

            Console.WriteLine($"{nameof(ulong1)} == {nameof(ulong2)} : {ulong1 == ulong2}");
            Console.WriteLine($"{nameof(ulong2)} == {nameof(ulong3)} : {ulong2 == ulong3}");

            #endregion

                  
            // use operators on integers
            int i1 = 5;
            int i2 = 2;
            // integers support equality operators
            bool b1 =  i1 == i2; // or inequality !=
            Console.WriteLine($"{nameof(b1)} = {b1}");
            // you can use the Equals method
            bool b2 = i1.Equals(i2);
            bool b3 = int.Equals(i1,i2);
            Console.WriteLine($"{nameof(b2)} = {b2}");
            Console.WriteLine($"{nameof(b3)} = {b3}");
            // integers support comparison operators
            bool b4 =  i1 > i2; 
            Console.WriteLine($"{nameof(b2)} = {b4}");
            // you can also use the CompareTo method
            int i1i2Compare = i1.CompareTo(i2);
            Console.WriteLine($"{nameof(i1i2Compare)} = {i1i2Compare}");
            // integers support arithmetic operators
            int i3 = i1*i2;
            Console.WriteLine($"{nameof(i3)} = {i3}");
            // is you use the division, the integer contains the rounded value less than or equal to the result (2.5)
            int i4 = i1/i2;
            Console.WriteLine($"{nameof(i4)} = {i4}");
            // DivideByZeroException if you try to divide by 0
            //int i5 = i1/0;

            // overflow
            // any bits that don't fit in the destination type is truncated
            int maxInt = int.MaxValue;
            int i6 = maxInt + 1;
            Console.WriteLine($"{nameof(i6)} = {i6}");

            // parse an int from a string
            int i7 = int.Parse("20");
            Console.WriteLine($"{nameof(i7)} = {i7}");
            // TryParse doesn't throw an exception
            bool parseResult = int.TryParse("abc", out int i8);
            Console.WriteLine($"{nameof(parseResult)} = {parseResult}");
            // see standard numeric formats
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
            string str = maxInt.ToString("N");
            Console.WriteLine($"{nameof(str)} = {str}");
            // in a string interpolation
            Console.WriteLine($"{nameof(maxInt)} = {maxInt:N}");
            
        }
    }
}
