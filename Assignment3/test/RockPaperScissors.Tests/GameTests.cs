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
            string p1Move = "rock";
            string p2Move = "scissors";
            string expected = $@"Please enter ""rock"", ""paper"", or ""scissors"": <<{p1Move}
>>Please enter ""rock"", ""paper"", or ""scissors"": <<{p2Move}
>>Player1 played: {p1Move}
>>Player2 played: {p2Move}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
                    {
                        Player player1 = new Player("Player1", new HumanPlayer());
                        Player player2 = new Player("Player2", new HumanPlayer());
                        Game.PlayRound(player1, player2);
                    });
        }
    }
}