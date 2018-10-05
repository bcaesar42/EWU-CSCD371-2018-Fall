using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class TestDivision
    {
        [TestMethod]
        public void TestDiv_12_4()
        {
            string expression = "12/4";
            string answer = "3";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }
    }
}
