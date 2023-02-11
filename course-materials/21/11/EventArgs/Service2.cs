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
                workDone(this, EventArgs.Empty);
            }
        }
    }
}