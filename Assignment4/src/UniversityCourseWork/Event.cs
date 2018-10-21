using System;

namespace Assignment4.Tests
{
    public class Event : Gathering
    {
        public Event()
            : base(null)
        { }

        public Event(string name)
            : base(name)
        { }

        public DateTime Date { get; set; }

        override
        public string GetSummaryInformation()
        {
            return "Event Name: " + GatheringName + Environment.NewLine +
                "Event Date: " + Date;
        }
    }
}