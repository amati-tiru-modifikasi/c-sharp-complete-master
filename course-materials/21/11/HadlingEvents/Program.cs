using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var service1 = new Service1();
            service1.workDone += new WorkDoneHandler(Service1WorkDone);
            var service2 = new Service2();
            service2.workDone += new EventHandler(Service2WorkDone);
            var service3 = new Service3();
            service3.workDone += new EventHandler<WorkDoneEventArgs>(Service3WorkDone);
            int[] workItems = { 1, 2, 3, 4 };
            foreach (var item in workItems)
            {
                service1.DoSomeWork(item);
                service2.DoSomeWork(item);
                service3.DoSomeWork(item);
            }
        }

        private static void Service1WorkDone(object sender, WorkDoneEventArgs eventArgs)
        {
            Console.WriteLine($"WorkItem {eventArgs.WorkItemId} performed by service1");
        }
        private static void Service2WorkDone(object sender, EventArgs eventArgs)
        {
            Console.WriteLine($"WorkItem {((WorkDoneEventArgs)eventArgs).WorkItemId} performed by service1");
        }
        private static void Service3WorkDone(object sender, WorkDoneEventArgs eventArgs)
        {
            Console.WriteLine($"WorkItem {eventArgs.WorkItemId} performed by service3");
        }
    }
}
