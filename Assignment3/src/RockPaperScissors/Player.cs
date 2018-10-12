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

        public string GetMove()
        {
            return this.playerType.MakeMove();
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

        public string GetName()
        {
            return this.name;
        }
    }
}