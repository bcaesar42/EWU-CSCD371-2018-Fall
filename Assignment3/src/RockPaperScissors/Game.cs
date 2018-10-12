using System;

namespace RockPaperScissors
{
    public class Game
    {
        public static void Main(string[] args)
        {
            bool playAgain = true;
            Player player1;
            Player player2;

            do
            {
                player1 = new Player("You", new HumanPlayer());
                player2 = new Player("The computer", new ComputerPlayer());
                (Player loser, int lifeLost) roundResult;

                while (player1.GetLife() > 0 && player2.GetLife() > 0)
                {
                    roundResult = PlayRound(player1, player2);
                    ProcessResult(roundResult.loser, roundResult.lifeLost);
                    Console.WriteLine($"Current life for \"{player1.GetName()}\" is: {player1.GetLife()}");
                    Console.WriteLine($"Current life for \"{player2.GetName()}\" is: {player2.GetLife()}" + Environment.NewLine);
                }

                Console.Write("Do you want to play another game?(y/n): ");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    playAgain = false;
                }
                Console.Write(Environment.NewLine);
            } while (playAgain);
        }

        private static (Player loser, int lifeLost) PlayRound(Player player1, Player player2)
        {
            string player1Move = player1.GetMove();
            string player2Move = player2.GetMove();

            if (player1Move.Equals(player2Move))
            {
                return (null, 0);
            }
            else if (player1Move.Equals("rock"))
            {
                if (player2Move.Equals("scissors"))
                {
                    return (player2, 20);
                }
                else //player2 had "paper"
                {
                    return (player1, 10);
                }
            }
            else if (player1Move.Equals("scissors"))
            {
                if (player2Move.Equals("paper"))
                {
                    return (player2, 15);
                }
                else //player2 had "rock"
                {
                    return (player1, 20);
                }
            }
            else //player1 had "paper"
            {
                if (player2Move.Equals("rock"))
                {
                    return (player2, 10);
                }
                else //player2 had "scissors"
                {
                    return (player1, 15);
                }
            }
        }

        public static void ProcessResult(Player loser, int lifeLost)
        {
            if (loser != null)
            {
                Console.WriteLine(loser.GetName() + " lost the round, and lost "
                                + lifeLost + " life.");
                loser.SubtractLife(lifeLost);
            }
            else
            {
                Console.WriteLine("This round was a tie.");
            }
        }
    }
}
