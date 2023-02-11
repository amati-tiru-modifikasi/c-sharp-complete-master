using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var service1 = new Service1();
            var service2 = new Service2();
            int[] workItems = {1, 2, 3, 4};
            foreach (var item in workItems)
            {
                service1.DoSomeWork(item);
                service2.DoSomeWork(item);
            }
        }
    }
}
