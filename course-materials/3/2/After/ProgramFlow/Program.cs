using System;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Statement 1");
            Console.WriteLine("Statement 2");
            int randomInt = new Random().Next();
            if ( randomInt % 2 == 0)
            {
                Console.WriteLine("If Statement 1");
                Console.WriteLine("If Statement 2");
            }
            else
            {
                Console.WriteLine("If Statement 3");
                Console.WriteLine("If Statement 4");
            }

            for (var i = 0; i < 10; i++)
            {
                if (i % 3 == 0) continue;
                if (i == 8)
                {
                    break;
                }
                Console.WriteLine($"For Statement {i}");

            }
        }
    }
}
