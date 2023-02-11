using System;

namespace DoWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region do...while

            Console.WriteLine("do...while");
            int counter1 = 0;
            do
            {
                Console.WriteLine(counter1);
                counter1++;
            } while (counter1 < 10);

            #endregion

            #region do...while at least one execution

            Console.WriteLine("do...while at least one execution");
            int counter2 = 0;
            do
            {
                Console.WriteLine(counter2);
                counter2++;
            } while (false);

            #endregion

            #region do...while with a break
            
            Console.WriteLine("do...while with a break");
            int counter3 = 0;
            do
            {
                Console.WriteLine(counter3);
                counter3++;
                if (counter3 == 5)
                {
                    break;
                }
            } while (counter3 < 10);
            
            #endregion

        }
    }
}
