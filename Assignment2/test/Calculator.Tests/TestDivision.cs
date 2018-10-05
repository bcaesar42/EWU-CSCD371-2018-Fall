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

        [TestMethod]
        public void TestDivideByZero()
        {
            string expression = "95/0";
            string answer = "Invalid Expression: Cannot divide by zero.";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>{answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestDivide_Positive_By_Positive()
        {
            string expression = "264/12";
            string answer = "22";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestDivide_Positive_By_Negative()
        {
            string expression = "2001/-83";
            string answer = "-24";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestDivide_Negative_By_Positive()
        {
            string expression = "-753/42";
            string answer = "-17";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestDivide_Negative_By_Negative()
        {
            string expression = "-2791/-74";
            string answer = "37";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestDivide_Positive_By_Maxval()
        {
            string expression = "2018/" + int.MaxValue;
            string answer = "0";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestDivide_Positive_By_Minval()
        {
            string expression = "2013/" + int.MinValue;
            string answer = "0";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }

        [TestMethod]
        public void TestDivide_Minval_By_Maxval()
        {
            string expression = int.MinValue + "/" + int.MaxValue;
            string answer = "-1";

            string expected = $@">>Please Enter an Equation: <<{expression}
>>= {answer}
>>Press any key to exit.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Calculator.Main);
        }
    }
}
