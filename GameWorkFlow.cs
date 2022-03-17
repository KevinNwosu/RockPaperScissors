namespace RockPaperScissors
{
    public class GameWorkFlow
    {
        public void Run()
        {
            WinTracker w = new WinTracker();
            bool playing = true;
            while (playing)
            {
                string promptPlayer1 = "Enter implementation for player 1. ";
                int choice = ConsoleIO.PromptPlayerType(promptPlayer1);
                Console.Clear();
                int player1Choice = GetPlayChoice(choice);

                string promptPlayer2 = "Enter implementation for player 2. ";
                int choice2 = ConsoleIO.PromptPlayerType(promptPlayer2);
                Console.Clear();
                int player2Choice = GetPlayChoice(choice2);

                int result = GetResult(player1Choice, player2Choice);

                if (result == 1)
                {
                    w.TieCount = w.TieCount + 1;
                }
                else if (result == 2)
                {
                    w.Player1Count = w.Player1Count + 1;
                }
                else if (result == 3)
                {
                    w.Player2Count = w.Player2Count + 1;
                }

                if (w.Player1Count == 2 || w.Player2Count == 2)
                {
                    playing = false;
                }
                Console.WriteLine($"Player 1 chose {(PlayerChoice)player1Choice} and Player 2 chose {(PlayerChoice)player2Choice}");

                ConsoleIO.PrintResult(result);

                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"Player 1 won {w.Player1Count} times and Player 2 won {w.Player2Count} times, there were {w.TieCount} ties");
            

        }
        public int GetResult(int playerOneChoice, int playerTwoChoice)
        {
            if (playerOneChoice == playerTwoChoice)
            {
                return 1;
            }

            // player one win conditions
            if ((playerOneChoice == (int)PlayerChoice.ROCK && playerTwoChoice == (int)PlayerChoice.SCISSORS) ||
                (playerOneChoice == (int)PlayerChoice.PAPER && playerTwoChoice == (int)PlayerChoice.ROCK ||
                (playerOneChoice == (int)PlayerChoice.SCISSORS && playerTwoChoice == (int)PlayerChoice.PAPER)))
            {
                return 2;
            }

            return 3;
        }
        public int GetPlayChoice(int input)
        {
            switch (input)
            {
                case 1:
                    RandomPlayer r1 = new RandomPlayer();
                    return r1.GetPlayerBehaviour();
                case 2:
                    ConsolePlayer c1 = new ConsolePlayer();
                    return c1.GetPlayerBehaviour();
                case 3:
                    AlwaysRock ar1 = new AlwaysRock();
                    return ar1.GetPlayerBehaviour();
                case 4:
                    AlwaysPaper ap1 = new AlwaysPaper();
                    return ap1.GetPlayerBehaviour();
                case 5:
                    AlwaysScissors s1 = new AlwaysScissors();
                    return s1.GetPlayerBehaviour();
                default:
                    return 6;
            }
        }
        public enum PlayerChoice
        {
            ROCK = 1,
            PAPER = 2,
            SCISSORS = 3
        }

        public enum GameResult
        {
            TIE,
            PLAYER1WIN,
            PLAYER2WIN
        }
    }
}
