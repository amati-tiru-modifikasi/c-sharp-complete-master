using System;

namespace DelegatesPlayground
{
    class Program
    {
        internal delegate void PrintHandler();
        internal delegate int CalculationHandler(int x, int y);
        internal delegate void WorkDoneHandler();
        
        static void Main(string[] args)
        {
            // RunDelegatesExamples();
            RunMulticastDelegatesExamples();
            // RunAnonymousMethodExample();
        }

        private static void RunDelegatesExamples()
        {
            CalculationHandler calculation = Sum;
            Console.WriteLine($"Sum = {calculation(4,7)}");
            calculation = Product;
            Console.WriteLine($"Product = {calculation(4,7)}");
        }

        private static void RunAnonymousMethodExample()
        {
            WorkDoneHandler workDoneDelegate = delegate ()
            {
                Console.WriteLine("I've done some work!");
            };
            workDoneDelegate();
        }

        private static void RunMulticastDelegatesExamples()
        {
            PrintHandler delegate1 = PrintMethod1;
            PrintHandler delegate2 = PrintMethod2;
            PrintHandler delegate3 = PrintMethod3;


            delegate1 += delegate2;
            delegate1();
            Console.WriteLine();
            delegate1 += delegate3;
            delegate1();

            CalculationHandler delegate4 = Sum;
            CalculationHandler delegate5 = Sum;
            CalculationHandler delegate6 = Sum;

            CalculationHandler multicastDelegate = delegate4 + delegate5 + delegate6;
            int sumResult = multicastDelegate(1, 4);
            Console.WriteLine($"Invoking multicastDelegate returned sumResult = {sumResult}");
        }

        static void PrintMethod1()
        {
            Console.WriteLine("Hi from delegate 1");
        }

        static void PrintMethod2()
        {
            Console.WriteLine("Hi from delegate 2");
        }

        static void PrintMethod3()
        {
            Console.WriteLine("Hi from delegate 3");
        }

        static int Sum(int x, int y)
        {
            //Console.WriteLine($"Executing Sum, return {x + y}");
            return x + y;
        }
        static int Product(int x, int y)
        {
            return x * y;
        }
    }
}
