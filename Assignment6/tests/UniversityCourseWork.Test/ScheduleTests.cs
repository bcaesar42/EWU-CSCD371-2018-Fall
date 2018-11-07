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
    }
}
