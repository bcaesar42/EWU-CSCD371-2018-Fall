using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class TestSub
    {
        [TestMethod]
        public void TestSub_12_4()
        {
            string expression = "12-4";
            string answer = "8";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestSubZero()
        {
            string expression = "95-0";
            string answer = "95";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestSub_Positive_from_Positive()
        {
            string expression = "9-5";
            string answer = "4";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestSub_Positive_from_Negative()
        {
            string expression = "-7-8";
            string answer = "-15";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestSub_Negative_from_Positive()
        {
            string expression = "3--2";
            string answer = "5";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestSub_Negative_from_Negative()
        {
            string expression = "-4--7";
            string answer = "3";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }
    }
}