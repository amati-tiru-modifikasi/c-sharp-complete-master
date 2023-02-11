using System;

namespace WhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while

            Console.WriteLine("while");
            int counter1 = 0;
            while (counter1 < 10)
            {
                Console.WriteLine(counter1);
                counter1++;
            }

            #endregion

            #region while no execution, unreachable code

            Console.WriteLine("while no execution");
            int counter2 = 0;
            while (false)
            {
                Console.WriteLine(counter2);
                counter2++;
            }

            #endregion

            #region while with a break

            Console.WriteLine("while with a break");
            int counter3 = 0;
            while (counter3 < 10)
            {
                Console.WriteLine(counter3);
                counter3++;
                if (counter3 == 5)
                {
                    break;
                }
            }

            #endregion
        }
    }
}
