using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class TestAdd
    {
        [TestMethod]
        public void TestAdd_12_4()
        {
            string expression = "12+4";
            string answer = "16";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestAddZero()
        {
            string expression = "95+0";
            string answer = "95";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestAdd_Positive_and_Positive()
        {
            string expression = "56+91";
            string answer = "147";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestAdd_Positive_and_Negative()
        {
            string expression = "2001+-83";
            string answer = "1918";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestAdd_Negative_and_Positive()
        {
            string expression = "-753+42";
            string answer = "-711";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestAdd_Negative_and_Negative()
        {
            string expression = "-2791+-74";
            string answer = "-2865";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestAdd_Minval_and_Maxval()
        {
            string expression = int.MinValue + "+" + int.MaxValue;
            string answer = "-1";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }
    }
}