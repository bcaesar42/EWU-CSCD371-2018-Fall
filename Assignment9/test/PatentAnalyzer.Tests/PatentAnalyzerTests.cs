using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment9;
using System.Collections.Generic;
using System;

namespace Assignment9.Tests
{
    [TestClass]
    public class PatentAnalyzerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InventorNames_NullCountry_Exception()
        {
            List<string> results = PatentDataAnalyzer.InventorNames(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InventorNames_EmptyCountry_Exception()
        {
            List<string> results = PatentDataAnalyzer.InventorNames("");
        }

        [TestMethod]
        public void InventorNames_USA_MultipleResults()
        {
            List<string> results = PatentDataAnalyzer.InventorNames("USA");
            List<string> expected = new List<string>() { "Benjamin Franklin", "Orville Wright",
                                    "Wilbur Wright", "Samuel Morse", "John Michaelis", "Mary Phelps Jacob"};

            Assert.AreEqual(expected.Count, results.Count);

            foreach (string item in results)
            {
                Assert.IsTrue(expected.Contains(item));
            }
        }

        [TestMethod]
        public void InventorNames_UK_OneResult()
        {
            List<string> results = PatentDataAnalyzer.InventorNames("UK");
            List<string> expected = new List<string>() { "George Stephenson" };

            Assert.AreEqual(expected.Count, results.Count);

            foreach (string item in results)
            {
                Assert.IsTrue(expected.Contains(item));
            }
        }

        [TestMethod]
        public void InventorNames_CounryNotInData_EmptyList()
        {
            List<string> results = PatentDataAnalyzer.InventorNames("Canada");
            Assert.IsTrue(results.Count == 0);
        }
    }
}
