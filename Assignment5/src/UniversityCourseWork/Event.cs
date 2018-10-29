using System;

namespace Assignment5
{
    public class Event : Gathering
    {
        public Event()
            : base(null)
        {
            Date = new DateTime(2018, 1, 1);
        }

        public Event(string name, DateTime date)
            : base(name)
        {
            Date = date;
        }

        public DateTime Date { get; set; }

        override
        public string GetSummaryInformation()
        {
            return "Event Name: " + GatheringName + Environment.NewLine +
                "Event Date: " + Date;
        }

        public (string, DateTime) Deconstruct()
        {
            return (GatheringName, Date);
        }
    }
}