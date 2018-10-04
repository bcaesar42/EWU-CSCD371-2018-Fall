using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strings.Tests
{
    [TestClass]
    public class StringsMethodsTests
    {
        [TestMethod]
        public void Test_ToUpper()
        {
            string input = "bryan caesar";
            string expected = "BRYAN CAESAR";

            Assert.AreEqual(input.ToUpper(), expected);
        }

        [TestMethod]
        public void Test_ToLower()
        {
            string input = "BRYAN CAESAR";
            string expected = "bryan caesar";

            Assert.AreEqual(input.ToLower(), expected);
        }
    }
}
