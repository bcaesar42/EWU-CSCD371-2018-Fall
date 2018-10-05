using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class TestMultiplication
    {
        [TestMethod]
        public void TestMult_5_4()
        {
            string expression = "5*4";
            string answer = "20";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestMultiplyByZero()
        {
            string expression = "42*0";
            string answer = "0";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestMult_Positive_By_Positive()
        {
            string expression = "84*91";
            string answer = "7644";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestMult_Positive_By_Negative()
        {
            string expression = "25*-65";
            string answer = "-1625";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestMult_Negative_By_Positive()
        {
            string expression = "-53*3";
            string answer = "-159";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestMult_Negative_By_Negative()
        {
            string expression = "-12*-7";
            string answer = "84";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestMult_Zero_By_Maxval()
        {
            string expression = "0*" + int.MaxValue;
            string answer = "0";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }
    }
}