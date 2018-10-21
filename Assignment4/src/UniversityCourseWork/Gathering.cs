using System;

namespace Assignment4
{
    public abstract class Gathering
    {
        public Gathering(string name)
        {
            this.GatheringName = name;
            InstantiationCount++;
        }

        public static int InstantiationCount { get; private set; } = 0;
        public string GatheringName { get; }
        public string Location { get; set; }

       // public abstract string GetSummaryInformation();
    }
}
