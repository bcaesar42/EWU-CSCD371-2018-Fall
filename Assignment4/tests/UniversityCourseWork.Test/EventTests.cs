using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment4.Tests
{
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        public void Deconstruct_DefaultConstructor_DefaultValues()
        {
            Event testEvent = new Event();
            Assert.AreEqual((null, new DateTime(2018, 1, 1)), testEvent.Deconstruct());
        }
    }
}
