using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6.Tests
{
    [TestClass]
    public class TestMyConsole
    {
        [TestMethod]
        public void TestWriteLine()
        {
            MyConsole terminal = new MyConsole();
            string expected = "Hello World!";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () => terminal.WriteLine(expected));
        }
    }
}
