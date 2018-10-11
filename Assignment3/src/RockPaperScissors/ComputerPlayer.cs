using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class ComputerPlayer : MoveBehavior
    {
        public string MakeMove()
        {
            List<string> validMoves = new List<string>(){"rock", "paper", "scissors"};

            Random rand = new Random();
            return validMoves[rand.Next(3)];
        }
    }
}