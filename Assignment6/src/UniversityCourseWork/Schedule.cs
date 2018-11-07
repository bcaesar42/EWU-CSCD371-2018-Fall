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
    }
}
