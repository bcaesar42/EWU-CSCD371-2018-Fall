using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment4;

namespace Assignment4.Tests
{
    [TestClass]
    public class UniversityCourseTests
    {
        [TestMethod]
        public void Constructor_IsGathering_True()
        {
            Assert.IsInstanceOfType(new UniversityCourse(), typeof(Gathering));
        }
    }
}
