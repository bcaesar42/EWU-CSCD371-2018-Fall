using System;

namespace Assignment6
{
    public struct Schedule
    {
        public WeekDays DayOfWeek { get; }
        public Quarters Quarter { get; }
        public Time StartTime { get; }
        public TimeSpan Duration { get; }
    }
}
