using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment4.Tests
{
    [TestClass]
    public class UniversityCourseTests
    {
        [TestMethod]
        public void InstantiationCount_4Gatherings_AtLeast4()
        {
            Gathering gathering = new UniversityCourse();
            gathering = new UniversityCourse("CS Course", 4,
                    new DateTime(2018, 9, 20), new DateTime(2018, 12, 8));
            gathering = new Event();
            gathering = new Event("Concert", new DateTime());

            Assert.IsTrue(Gathering.InstantiationCount >= 4);
        }

        [TestMethod]
        public void Constructor_IsGathering_True()
        {
            Assert.IsInstanceOfType(new UniversityCourse(), typeof(Gathering));
        }

        [TestMethod]
        public void DefaultConstructor_GetName_Null()
        {
            Assert.IsNull(new UniversityCourse().GatheringName);
        }

        [TestMethod]
        public void ExplictConstructor_GetName_CSCD371()
        {
            Assert.AreEqual("CSCD371", new UniversityCourse("CSCD371", 5,
                    new DateTime(2018, 9, 20), new DateTime(2018, 12, 8)).GatheringName);
        }

        [TestMethod]
        public void GetCredits_5CreditCourse_5()
        {
            UniversityCourse testCourse = new UniversityCourse("Test Course", 5,
                    new DateTime(2018, 9, 20), new DateTime(2018, 12, 8));
            Assert.AreEqual(5, testCourse.CreditValue);
        }

        [TestMethod]
        public void SetCredits_SettingTo4_NoException()
        {
            UniversityCourse testCourse = new UniversityCourse("Test Course", 2,
                    new DateTime(2018, 9, 20), new DateTime(2018, 12, 8));
            testCourse.CreditValue = 4;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetCredits_SetToNegative_Exception()
        {
            UniversityCourse testCourse = new UniversityCourse("Test Course", 2,
                    new DateTime(2018, 9, 20), new DateTime(2018, 12, 8));
            testCourse.CreditValue = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetCredits_SetTooLarge_Exception()
        {
            UniversityCourse testCourse = new UniversityCourse("Test Course", 2,
                    new DateTime(2018, 9, 20), new DateTime(2018, 12, 8));
            testCourse.CreditValue = 50;
        }
    }
}
