using System;

namespace Events
{
    internal class Service1
    {
        // event with custom delegate
        internal event WorkDoneHandler workDone;

        internal void DoSomeWork(int workItemId)
        {
            // Do some work
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