using System;

namespace Assignment5
{
    public abstract class Gathering : IEvent
    {
        public Gathering(string name, string location)
        {
            GatheringName = name;
            Location = location;
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

        public static DateTime GetDateFromUser(string prompt)
        {
            MyConsole terminal = new MyConsole();

            while (true)
            {
                terminal.Write(prompt);
                string userInput = terminal.ReadLine();
                string[] dateComponents = userInput.Split("-");
                try
                {
                    if (dateComponents.Length != 3)
                    {
                        throw new ArgumentException("Input not in yyyy-mm-dd format.");
                    }
                    return new DateTime(int.Parse(dateComponents[0]), int.Parse(dateComponents[1]), int.Parse(dateComponents[2]));
                }
                catch (Exception)
                {
                    terminal.WriteLine("Invalid Input - Please make sure that you are entering a valid date (yyyy-mm-dd).");
                }
            }
        }
    }
}
