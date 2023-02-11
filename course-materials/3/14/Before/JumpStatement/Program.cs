using System;

namespace JumpStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static string GetCodeString()
        {
            return new string[4] { "Code1", "Code2", "Code999", "Invalid" }[new Random().Next(0, 4)];
        }
    }
}