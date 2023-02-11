using System;
using System.Threading;

namespace Events
{
    internal class Service2
    {
        // event with built in C# class
        internal event EventHandler workDone;
        internal void DoSomeWork(int workItemId)
        {
            // Do some work
            Thread.Sleep(750);
            OnWorkDone(workItemId);
        }

        private void OnWorkDone(int workItemId)
        {
            if (workDone != null)
            {
                workDone(this, new WorkDoneEventArgs(workItemId));
            }
        }
    }
}