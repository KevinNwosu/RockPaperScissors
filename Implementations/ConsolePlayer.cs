namespace RockPaperScissors
{
    public class ConsolePlayer : IChoiceGetter
    {
        public int GetPlayerBehaviour()
        {
            return ConsoleIO.GetConsolePlayerInput();
        }
    }
}
