namespace RockPaperScissors
{
    public class AlwaysRock : IChoiceGetter
    {
        public int GetPlayerBehaviour()
        {
            return 1;
        }
    }
}
