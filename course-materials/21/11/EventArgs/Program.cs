using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var service1 = new Service1();
            var service2 = new Service2();
            var service3 = new Service3();
            int[] workItems = {1, 2, 3, 4};
            foreach (var item in workItems)
            {
                service1.DoSomeWork(item);
                service2.DoSomeWork(item);
                service3.DoSomeWork(item);
            }
        }
    }
}
