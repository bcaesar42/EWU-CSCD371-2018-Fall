using System;

namespace Assignment5
{
    public class UniversityCourse : Gathering
    {
        public UniversityCourse()
            : base(null)
        {
            CreditValue = 0;
        }

        public UniversityCourse(string name, int credits, DateTime start, DateTime end)
            : base(name)
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

        override
        public string GetSummaryInformation()
        {
            return "Course Name: " + GatheringName + Environment.NewLine +
                "Credits: " + CreditValue + Environment.NewLine + CourseSchedule;
        }
    }
}
