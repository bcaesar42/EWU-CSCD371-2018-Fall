using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RockPaperScissors.Tests
{
    [TestClass]
    public class ComputerPlayerTests
    {
        [TestMethod]
        public void ConstructorNotNull()
        {
            Player computerPlayer = new Player("The Computer", new ComputerPlayer());
            Assert.IsNotNull(computerPlayer);
            Player humanPlayer = new Player("Human", new HumanPlayer());
            Assert.IsNotNull(humanPlayer);
        }

        [TestMethod]
        public void GetMoveIsValidMoveComputer()
        {
            List<string> validMoves = new List<string>(){"rock", "paper", "scissors"};
            Player testPlayer = new Player("The Computer", new ComputerPlayer());
            for (int loopCount = 0; loopCount < 50; loopCount++)
            {
               CollectionAssert.Contains(validMoves, testPlayer.GetMove());
            }
        }

        [TestMethod]
        public void GetMoveIsValidMoveHuman()
        {
            List<string> validMoves = new List<string>(){"rock", "paper", "scissors"};
            Player testPlayer = new Player("The Computer", new HumanPlayer());
            for (int loopCount = 0; loopCount < 50; loopCount++)
            {
               CollectionAssert.Contains(validMoves, testPlayer.GetMove());
            }
        }

        [TestMethod]
        public void GetMoveNotNull()
        {
            Player testPlayer = new Player("The Computer", new ComputerPlayer());
            for (int loopCount = 0; loopCount < 50; loopCount++)
            {
                Assert.IsNotNull(testPlayer.GetMove());
            }
        }

        [TestMethod]
        public void SubtractLifeAndGetLife()
        {
            Player testPlayer = new Player("The Computer", new ComputerPlayer());
            Assert.AreEqual(testPlayer.GetLife(), 100);
            testPlayer.SubtractLife(20);
            Assert.AreEqual(testPlayer.GetLife(), 80);
            testPlayer.SubtractLife(15);
            Assert.AreEqual(testPlayer.GetLife(), 65);
            testPlayer.SubtractLife(10);
            Assert.AreEqual(testPlayer.GetLife(), 55);
        }

        [TestMethod]
        public void GetNameReturnsCorrectString()
        {
            Player testPlayer = new Player("The Computer", new ComputerPlayer());
            Assert.AreEqual(testPlayer.GetName(), "The Computer");
        }
    }
}
