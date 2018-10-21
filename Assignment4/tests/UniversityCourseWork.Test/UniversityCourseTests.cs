using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment4;

namespace Assignment4.Tests
{
    [TestClass]
    public class UniversityCourseTests
    {
        [TestMethod]
        public void InstantiationCount_4Gatherings_4()
        {
            Gathering gathering = new UniversityCourse();
            gathering = new UniversityCourse("CS Course");
            gathering = new Event();
            gathering = new Event("Concert");

            Assert.AreEqual(4, Gathering.InstantiationCount);
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
            Assert.AreEqual(new UniversityCourse("CSCD371").GatheringName, "CSCD371");
        }

        
    }
}
