using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Assignment6.Tests
{
    [TestClass]
    public class UniversityCourseTests
    {
        static string[] names = { ".NET Programming", "SQL", "Design Patterns", "Lunch", "Monty Python" };
        static string[] locations = { "CEB", "PUB", "Living Room" };
        static DateTime[] dates = {new DateTime(2012,02,16), new DateTime(2013,06,24), new DateTime(2014,07,19),
                                            new DateTime(2016,04,13), new DateTime(2018,09, 22)};
        static List<UniversityCourse> testCourses;

        [TestInitialize]
        public void SetupMethod()
        {
            Gathering.ResetInstanceCount();
            testCourses = new List<UniversityCourse>();

            testCourses.Add(new UniversityCourse(names[0], locations[0], 4, dates[0], dates[1]));
            testCourses.Add(new UniversityCourse(names[3], locations[2], 12, dates[3], dates[4]));
            testCourses.Add(new UniversityCourse(names[2], locations[1], 5, dates[1], dates[3]));
        }

        [TestCleanup]
        public void CleanupTest()
        {
            
        }

        [TestMethod]
        public void InstantiationCount_3Gatherings_3()
        {
            Assert.AreEqual(3, Gathering.InstantiationCount);
        }

        [TestMethod]
        public void UniversityCourse_InheritsGathering_True()
        {
            Assert.IsInstanceOfType(testCourses[0], typeof(Gathering));
        }

        [TestMethod]
        public void UniversityCourse_InheritsIEvent_True()
        {
            Assert.IsInstanceOfType(testCourses[0], typeof(IEvent));
        }

        [TestMethod]
        public void UniversityCourse_GetName_Lunch()
        {
            Assert.AreEqual("Lunch", testCourses[1].GatheringName);
        }

        [TestMethod]
        public void GetCredits_4CreditCourse_4()
        {
            Assert.AreEqual(4, testCourses[0].CreditValue);
        }

        [TestMethod]
        public void SetCredits_SettingTo4_NoException()
        {
            Assert.AreEqual(12, testCourses[1].CreditValue);
            testCourses[1].CreditValue = 7;
            Assert.AreEqual(7, testCourses[1].CreditValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetCredits_SetToNegative_Exception()
        {
            testCourses[2].CreditValue = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetCredits_SetTooLarge_Exception()
        {
            testCourses[0].CreditValue = 50;
        }
    }
}
