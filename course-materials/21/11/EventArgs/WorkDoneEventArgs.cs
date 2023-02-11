using System;

namespace Events
{
    internal class WorkDoneEventArgs : EventArgs
    {
        public int WorkItemId { get; set; }
        public WorkDoneEventArgs(int workItemId)
        {
            WorkItemId = workItemId;
        }
    }
}