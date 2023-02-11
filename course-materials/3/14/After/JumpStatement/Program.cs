using System;

namespace JumpStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = GetCodeString();
            switch (code)
            {
                case "Code1":
                    Console.WriteLine($"{code}, case 1");
                    break;
                case "Code2":
                    Console.WriteLine($"{code}, case 2");
                    break;
                case "Code999":
                    Console.WriteLine($"{code}, case 999");
                    goto case "Invalid";
                case "Invalid":
                    Console.WriteLine("Invalid code string");
                    break;
            }

            for (int i = 0; i < 100; i++)
            {
                if (i == 6)
                {
                    continue;
                }

                if (i == 11)
                {
                    goto LoopEscape;
                }

                Console.WriteLine($"{i}");
            }

        LoopEscape:
            Console.WriteLine("I escaped from the loop");

            RecalculateOrderTotalAmount();
        }

        static string GetCodeString()
        {
            return new string[4] { "Code1", "Code2", "Code999", "Invalid" }[new Random().Next(0, 4)];
        }

        static void RecalculateOrderTotalAmount()
        {
            var isNewArticleInOrder = false;
            if (!isNewArticleInOrder)
            {
                Console.WriteLine("No new article");
                return;
            }
            // Recalculation
            Console.WriteLine("Recalculating");
        }
    }
}