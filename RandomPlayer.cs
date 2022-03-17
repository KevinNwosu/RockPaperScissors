namespace RockPaperScissors
{
    public class RandomPlayer : IChoiceGetter
    {
        private Random _rng = new Random();

        public int GetPlayerBehaviour()
        {
            return _rng.Next(1, 4);
        }
    }
}
