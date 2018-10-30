using System;

namespace Assignment5
{
    public class UniversityCourse : Gathering
    {
        private UniversityCourse(string name, string location, int credits, DateTime start, DateTime end)
            : base(name, location)
        {
            CreditValue = credits;
            StartDate = start;
            EndDate = end;
        }

        private int _CreditValue;
        public int CreditValue
        {
            get
            {
                return _CreditValue;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Credits can not be negative.");
                }
                else if (value > 15)
                {
                    throw new ArgumentException("Too many credits for one course.");
                }
                else
                {
                    _CreditValue = value;
                }
            }
        }

        public DateTime StartDate { get; set; }

        private DateTime _EndDate;
        public DateTime EndDate
        {
            get
            {
                return _EndDate;
            }
            set
            {
                if (_EndDate.CompareTo(StartDate) > 0)
                {
                    throw new ArgumentException("End date can't be before start date.");
                }
                _EndDate = value;
            }
        }

        public string CourseSchedule
        {
            get
            {
                return "From: " + StartDate + ", To: " + EndDate;
            }
        }

        override public string GetSummaryInformation()
        {
            return "Course Name: " + GatheringName + Environment.NewLine +
                "Credits: " + CreditValue + Environment.NewLine + CourseSchedule;
        }

        public static UniversityCourse MakeCourse()
        {
            MyConsole terminal = new MyConsole();
            terminal.Write("Enter the course name: ");
            string name = terminal.ReadLine();
            terminal.Write("Enter the course location: ");
            string location = terminal.ReadLine();
            int credits = InitializeCreditValue();
            DateTime startDate = Gathering.GetDateFromUser("Enter the start-date for the course: ");
            DateTime endDate = Gathering.GetDateFromUser("Enter the end-date for the course: ");
            return new UniversityCourse(name, location, credits, startDate, endDate);
        }

        private static int InitializeCreditValue()
        {
            MyConsole terminal = new MyConsole();
            int credits = -1;
            string userInput;

            do
            {
                terminal.Write("How many credits is the course worth?: ");
                userInput = terminal.ReadLine();

                try
                {
                    credits = int.Parse(userInput);

                    if (credits < 0 || credits > 15)
                    {
                        throw new ArgumentException("Invalid Input - Number not in valid range (0-15).");
                    }
                }
                catch (FormatException)
                {
                    terminal.WriteLine("Invalid Input - Not a number.");
                }
                catch (ArgumentException e)
                {
                    terminal.WriteLine(e.Message);
                }
            } while (credits < 0 || credits > 15);

            return credits;
        }
    }
}
