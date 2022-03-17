namespace RockPaperScissors
{
    public class AlwaysPaper : IChoiceGetter
    {
        public int GetPlayerBehaviour()
        {
            return 2;
        }
    }
}
