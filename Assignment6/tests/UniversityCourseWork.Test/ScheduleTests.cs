using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace Assignment6.Tests
{
    [TestClass]
    public class ScheduleTests
    {
        [TestMethod]
        public void SizeOf_LessThanOrEqualSixteenBytes()
        {
            Assert.IsTrue(Marshal.SizeOf(typeof(Schedule)) <= 16);
        }

        [TestMethod]
        public void IsReadOnly_DayOfWeek()
        {
            Assert.IsFalse(typeof(Schedule).GetProperty("DayOfWeek").CanWrite);
        }

        [TestMethod]
        public void IsReadOnly_Quarter()
        {
            Assert.IsFalse(typeof(Schedule).GetProperty("Quarter").CanWrite);
        }

        [TestMethod]
        public void IsReadOnly_StartTime()
        {
            Assert.IsFalse(typeof(Schedule).GetProperty("StartTime").CanWrite);
        }

        [TestMethod]
        public void IsReadOnly_Duration()
        {
            Assert.IsFalse(typeof(Schedule).GetProperty("Duration").CanWrite);
        }

        [TestMethod]
        public void SettingDaysOfWeek_ParseMultipleDaysFromString()
        {
            string daysString = "Monday Wednesday Friday";
            Time startTime = new Time(1, 2, 3);
            TimeSpan duration = new TimeSpan(4, 5, 6);
            Schedule schedule = new Schedule(Schedule.ParseDays(daysString), Quarters.Fall, startTime, duration);
            Assert.AreEqual("Monday, Wednesday, Friday", schedule.DayOfWeek.ToString());
        }

        [TestMethod]
        public void SettingDaysOfWeek_SetToAllDays()
        {
            string daysString = "Monday Tuesday Wednesday Thursday Friday Saturday Sunday";
            Time startTime = new Time(1, 2, 3);
            TimeSpan duration = new TimeSpan(4, 5, 6);
            Schedule schedule = new Schedule(Schedule.ParseDays(daysString), Quarters.Fall, startTime, duration);
            Assert.AreEqual("Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday", schedule.DayOfWeek.ToString());
        }

        [TestMethod]
        public void SettingDaysOfWeek_SetToOnlyThursday()
        {
            string daysString = "Thursday";
            Time startTime = new Time(1, 2, 3);
            TimeSpan duration = new TimeSpan(4, 5, 6);
            Schedule schedule = new Schedule(Schedule.ParseDays(daysString), Quarters.Fall, startTime, duration);
            Assert.AreEqual("Thursday", schedule.DayOfWeek.ToString());
        }

        [TestMethod]
        public void SettingQuarter_SetToFall()
        {
            Quarters quarter = Schedule.ParseQuarter("Fall");
            Time startTime = new Time(1, 2, 3);
            TimeSpan duration = new TimeSpan(4, 5, 6);
            Schedule schedule = new Schedule(WeekDays.Monday, quarter, startTime, duration);
            Assert.AreEqual("Fall", schedule.Quarter.ToString());
        }

        [TestMethod]
        public void SettingQuarter_SetToWinter()
        {
            Quarters quarter = Schedule.ParseQuarter("Winter");
            Time startTime = new Time(1, 2, 3);
            TimeSpan duration = new TimeSpan(4, 5, 6);
            Schedule schedule = new Schedule(WeekDays.Monday, quarter, startTime, duration);
            Assert.AreEqual("Winter", schedule.Quarter.ToString());
        }

        [TestMethod]
        public void SettingQuarter_SetToSpring()
        {
            Quarters quarter = Schedule.ParseQuarter("Spring");
            Time startTime = new Time(1, 2, 3);
            TimeSpan duration = new TimeSpan(4, 5, 6);
            Schedule schedule = new Schedule(WeekDays.Monday, quarter, startTime, duration);
            Assert.AreEqual("Spring", schedule.Quarter.ToString());
        }

        [TestMethod]
        public void SettingQuarter_SetToSummer()
        {
            Quarters quarter = Schedule.ParseQuarter("Summer");
            Time startTime = new Time(1, 2, 3);
            TimeSpan duration = new TimeSpan(4, 5, 6);
            Schedule schedule = new Schedule(WeekDays.Monday, quarter, startTime, duration);
            Assert.AreEqual("Summer", schedule.Quarter.ToString());
        }
    }
}
