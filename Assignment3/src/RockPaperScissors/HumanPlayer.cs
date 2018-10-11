using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class HumanPlayer : MoveBehavior
    {
        public string MakeMove()
        {
            List<string> validMoves = new List<string>(){"rock", "paper", "scissors"};
            string move;

            do
            {
                Console.Write("Please enter \"rock\", \"paper\", or \"scissors\": ");
                move = Console.ReadLine().ToLower();
            } while (!validMoves.Contains(move));

            return move;
        }
    }
}