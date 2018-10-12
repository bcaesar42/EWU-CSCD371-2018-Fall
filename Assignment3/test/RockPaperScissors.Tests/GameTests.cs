using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RockPaperScissors.Tests
{
    [TestClass]
    public class GamesTests
    {
        [TestMethod]
        public void ProcessResultPlayer1Lost20Life()
        {
            string expected = "Player1 lost the round, and lost 20 life.";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
                    Game.ProcessResult(new Player("Player1", new ComputerPlayer()), 20));
        }

        [TestMethod]
        public void PlayRound2Humans()
        {
            string expected = "Player1 lost the round, and lost 20 life.";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
                    Game.ProcessResult(new Player("Player1", new ComputerPlayer()), 20));
        }
    }
}