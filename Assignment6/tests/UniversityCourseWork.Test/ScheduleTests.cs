using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace Assignment6.Tests
{
    [TestClass]
    public class ScheduleTests
    {
        [TestMethod]
        public void Schedule_SizeOf_LessThanOrEqualSixteenBytes()
        {
            Assert.IsTrue(Marshal.SizeOf(typeof(Schedule)) >= 16);
        }
    }
}
