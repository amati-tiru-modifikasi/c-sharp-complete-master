using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region switch...case with boolean

            Console.WriteLine("switch...case with boolean");
            var randomBool = GenerateRandomBoolean();
            switch (randomBool)
            {
                case true:
                    Console.WriteLine("Generated true");
                    break;
                case false:
                    Console.WriteLine("Generated false");
                    break;
            }

            #endregion

            #region switch...case with integer

            Console.WriteLine("switch...case with integer");
            var randomInt = GenerateRandomBetween0And5();
            switch (randomInt)
            {
                case 1:
                    Console.WriteLine("Use case 1");
                    // Code to call is use case 1
                    break;
                case 2:
                    Console.WriteLine("Use case 2");
                    // Code to call is use case 2
                    break;
                case 3:
                    Console.WriteLine("Use case 3");
                    // Code to call is use case 3
                    break;
                case 4:
                    Console.WriteLine("Use case 4");
                    // Code to call is use case 4
                    break;
                case 5:
                    Console.WriteLine("Use case 5");
                    // Code to call is use case 5
                    break;
            }

            #endregion

            #region switch...case with string

            Console.WriteLine("switch...case with string");
            var code = GetCodeString();
            switch (code)
            {
                case "Code1":
                    Console.WriteLine($"{code}, case 1");
                    // Code to call is use case 1
                    break;
                case "Code2":
                    Console.WriteLine($"{code}, case 2");
                    // Code to call is use case 2
                    break;
                case "Code3":
                    Console.WriteLine($"{code}, case 3");
                    // Code to call is use case 3
                    break;
                default:
                    Console.WriteLine($"{code}, Invalid");
                    // Code to call is use case 4
                    break;
            }

            #endregion

            #region switch...case with enum

            Console.WriteLine("switch...case with enum");
            var codeEnum = GetCodeEnum();
            switch (codeEnum)
            {
                case Code.Code1:
                    Console.WriteLine($"{codeEnum}, case 1");
                    // Code to call is use case 1
                    break;
                case Code.Code2:
                    Console.WriteLine($"{codeEnum}, case 2");
                    // Code to call is use case 2
                    break;
                case Code.Code3:
                    Console.WriteLine($"{codeEnum}, case 3");
                    // Code to call is use case 3
                    break;
                default:
                    Console.WriteLine($"{codeEnum}, Invalid");
                    // Code to call is use case 4
                    break;
            }

            #endregion

            #region relational switch case

            Console.WriteLine("What is your weight?");
            string inputString = Console.ReadLine();
            if (!float.TryParse(inputString, out float weight)) 
            {
                Console.WriteLine("Invalid weight");
                return;
            }

            switch (weight)
            {
                case 0:
                    throw new Exception("The boxer's weight must be greater than 0kg");
                case <= 46:
                    throw new Exception("Minimum weight 46kg");
                case > 46 and <= 54:
                    Console.WriteLine($"Category for {weight}kg : Flyweight");
                    break;
                case > 54 and <= 57:
                    Console.WriteLine($"Category for {weight}kg : Bantamweight");
                    break;
                case > 57 and <= 60:
                    Console.WriteLine($"Category for {weight}kg : Featherweight");
                    break;
                case > 60 and <= 63.5f:
                    Console.WriteLine($"Category for {weight}kg : Lightweight");
                    break;
                case > 63.5f and <= 71:
                    Console.WriteLine($"Category for {weight}kg : Welterweight");
                    break;
                case > 71 and <= 80:
                    Console.WriteLine($"Category for {weight}kg : Middleweight");
                    break;
                case > 80 and <= 200:
                    Console.WriteLine($"Category for {weight}kg : Heavyweight");
                    break;
                case > 200:
                    throw new Exception("The boxer's weight must be lower or equal than 200kg");
            }

            #endregion

        }


        static bool GenerateRandomBoolean()
        {
            return Convert.ToBoolean(new Random().Next(0, 2));
        }

        static int GenerateRandomBetween0And5()
        {
            return new Random().Next(1, 6);
        }

        static string GetCodeString()
        {
            return new string[4] { "Code1", "Code2", "Code3", "Invalid" }[new Random().Next(0, 4)];
        }

        static Code GetCodeEnum()
        {
            return (Code)new Random().Next(0, 4);
        }
    }

    enum Code
    {
        Code1,
        Code2,
        Code3,
        Invalid
    }
}