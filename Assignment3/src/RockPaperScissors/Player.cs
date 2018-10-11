namespace RockPaperScissors
{
    public class Player
    {
        private string name;
        private int life;
        private MoveBehavior playerType;

        public Player(string name, MoveBehavior playerType)
        {
            this.name = name;
            this.life = 100;
            this.playerType = playerType;
        }

        public int GetMove()
        {
            string moveString = this.playerType.MakeMove();
            System.Console.WriteLine(this.name + " played: " + moveString);
            
            if (moveString.Equals("rock"))
            {
                return 3;
            }
            else if (moveString.Equals("scissors"))
            {
                return 2;
            }
            else //paper
            {
                return 1;
            }
        }

        public void SubtractLife(int lifeLost)
        {
            this.life -= lifeLost;

            if (this.life <= 0)
            {
                System.Console.WriteLine(this.name + " lost the game.");
            }
        }

        public int GetLife()
        {
            return this.life;
        }
    }
}