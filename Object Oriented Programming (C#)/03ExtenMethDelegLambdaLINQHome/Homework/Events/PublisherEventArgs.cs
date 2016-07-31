using System;

namespace Homework.Events
{
    public class PublisherEventArgs : EventArgs
    {
        public PublisherEventArgs()
        {
            this.Time = DateTime.Now;
        }

        public DateTime Time { get; }
    }
}
