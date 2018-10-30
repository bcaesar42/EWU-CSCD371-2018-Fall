using System;

namespace Assignment5
{
    public abstract class Gathering
    {
        public Gathering(string name, string location)
        {
            this.GatheringName = name;
            this.Location = location;
            InstantiationCount++;
        }

        public static int InstantiationCount { get; private set; } = 0;
        public string GatheringName { get; }
        public string Location { get; set; }

        public abstract string GetSummaryInformation();

        public static void ResetInstanceCount()
        {
            InstantiationCount = 0;
        }
    }
}
