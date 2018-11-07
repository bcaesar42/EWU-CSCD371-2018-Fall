using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6.Tests
{
    [TestClass]
    public class CalendarTests
    {
        [TestMethod]
        public void TestPrintOptions()
        {
            string expected = @"----------------------------------------------------
1.) Print current schedule.
2.) Add university course.
3.) Add one-time event.
0.) Exit.";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calendar.PrintOptions);
        }
    }
}
