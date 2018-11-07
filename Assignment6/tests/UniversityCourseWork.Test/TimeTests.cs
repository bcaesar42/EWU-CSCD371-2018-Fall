using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace Assignment6.Tests
{
    [TestClass]
    public class TimeTests
    {
        [TestMethod]
        public void SizeOf_LessThanOrEqualSixteenBytes()
        {
            Assert.IsTrue(Marshal.SizeOf(typeof(Time)) <= 16);
        }

        [TestMethod]
        public void IsReadOnly_Hour()
        {
            Assert.IsFalse(typeof(Time).GetProperty("Hour").CanWrite);
        }

        [TestMethod]
        public void IsReadOnly_Minute()
        {
            Assert.IsFalse(typeof(Time).GetProperty("Minute").CanWrite);
        }

        [TestMethod]
        public void IsReadOnly_Second()
        {
            Assert.IsFalse(typeof(Time).GetProperty("Second").CanWrite);
        }
    }
}