using System;
using System.Threading;

namespace Events
{
    internal class Service1
    {
        // event with custom delegate
        internal event WorkDoneHandler workDone;

        // internal void DoSomeWork(int workItemId)
        // {
        //     // Do some work
        //     Thread.Sleep(500);
        //     OnWorkDone(workItemId);
        // }

        internal void DoSomeWork(int workItemId)
        {
            // Do some work
            Thread.Sleep(500);
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