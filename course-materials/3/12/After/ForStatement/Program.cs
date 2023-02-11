using System;

namespace ForStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for statement

            Console.WriteLine("for statement");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            #endregion

            #region for statement with break 

            Console.WriteLine("for statement with break");
            for (int i = 0; i < 10; i++)
            {
                if (i == 6)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            
            #endregion

            #region for statement with continue

            Console.WriteLine("for statement with continue");
            for (int i = 0; i < 10; i++)
            {
                if (i == 6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            
            #endregion
        }
    }
}
