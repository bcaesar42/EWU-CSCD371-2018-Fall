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
                player2 = new Player("The computer player", new ComputerPlayer());

                while (player1.GetLife() > 0 && player2.GetLife() > 0)
                {
                    //Play a game (100 life)
                        ///Play a round
                }

                Console.Write("Do you want to play another game?(y/n): ");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    playAgain = false;
                }
            } while (playAgain);
        }
    }
}
