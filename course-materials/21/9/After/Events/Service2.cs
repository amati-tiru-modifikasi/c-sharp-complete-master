using System;

namespace Events
{
    internal class Service2
    {
        // event with built in C# class
        internal event EventHandler workDone;
        internal void DoSomeWork(int workItemId)
        {
            // Do some work
            OnWorkDone(workItemId);
        }

        private void OnWorkDone(int workItemId)
        {
            if (workDone != null)
            {
                Console.WriteLine($"Service 2 : Processing done for item - {workItemId}");
                workDone(this, EventArgs.Empty);
            }
        }
    }
}