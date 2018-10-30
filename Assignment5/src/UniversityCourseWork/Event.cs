using System;

namespace Assignment5
{
    public class Event : Gathering
    {
        public DateTime Date { get; set; }

        public Event(string name, string location, DateTime date)
            : base(name, location)
        {
            Date = date;
        }

        override public string GetSummaryInformation()
        {
            return "Event Name: " + GatheringName + Environment.NewLine +
                "Event Date: " + Date;
        }

        public (string, DateTime) Deconstruct()
        {
            return (GatheringName, Date);
        }

        public static Event MakeEvent()
        {
            MyConsole terminal = new MyConsole();
            terminal.Write("Enter the event name: ");
            string name = terminal.ReadLine();
            terminal.Write("Enter the event location: ");
            string location = terminal.ReadLine();
            DateTime date = Gathering.GetDateFromUser("Enter the date for the event: ");
            return new Event(name, location, date);
        }
    }
}