using System;

namespace Assignment6
{
    public struct Schedule
    {
        public WeekDays DayOfWeek { get; }
        public Quarters Quarter { get; }
        public Time StartTime { get; }
        public TimeSpan Duration { get; }

        public Schedule(WeekDays days, Quarters quarter, Time startTime, TimeSpan duration)
        {
            this.DayOfWeek = days;
            this.Quarter = quarter;
            this.StartTime = startTime;
            this.Duration = duration;
        }

        public static WeekDays ParseDays(string str)
        {
            string[] days = str.Split(" ");
            WeekDays result = new WeekDays();

            foreach (string day in days)
            {
                if (day == "Monday")
                {
                    result |= WeekDays.Monday;
                }
                else if (day == "Tuesday")
                {
                    result |= WeekDays.Tuesday;
                }
                else if (day == "Wednesday")
                {
                    result |= WeekDays.Wednesday;
                }
                else if (day == "Thursday")
                {
                    result |= WeekDays.Thursday;
                }
                else if (day == "Friday")
                {
                    result |= WeekDays.Friday;
                }
                else if (day == "Saturday")
                {
                    result |= WeekDays.Saturday;
                }
                else if (day == "Sunday")
                {
                    result |= WeekDays.Sunday;
                }
            }

            return result;
        }

        public static Quarters ParseQuarter(string quarter)
        {
            if (quarter == "Fall")
            {
                return Quarters.Fall;
            }
            else if (quarter == "Winter")
            {
                return Quarters.Winter;
            }
            else if (quarter == "Spring")
            {
                return Quarters.Spring;
            }
            else
            {
                return Quarters.Summer;
            }
        }
    }
}
