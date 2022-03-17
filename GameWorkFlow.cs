namespace RockPaperScissors
{
    public class GameWorkFlow
    {
        public void Run()
        { 
            string promptPlayer1 = "Enter implementation for player 1. ";
            int choice = ConsoleIO.PromptPlayerType(promptPlayer1);
            Console.Clear();
            int player1Choice = 0;

            switch (choice)
            {
                case 1:
                    RandomPlayer r1 = new RandomPlayer();
                    player1Choice = r1.GetPlayerBehaviour();
                    break;
                case 2:
                    ConsolePlayer c1 = new ConsolePlayer();
                    player1Choice = c1.GetPlayerBehaviour();
                    break;
                case 3:
                    AlwaysRock ar1 = new AlwaysRock();
                    player1Choice = ar1.GetPlayerBehaviour();
                    break;
                case 4:
                    AlwaysPaper ap1 = new AlwaysPaper();
                    player1Choice = ap1.GetPlayerBehaviour();
                    break;
                case 5:
                    AlwaysScissors s1 = new AlwaysScissors();
                    player1Choice = s1.GetPlayerBehaviour();
                    break;
            }

            string promptPlayer2 = "Enter implementation for player 2. ";
            int choice2 = ConsoleIO.PromptPlayerType(promptPlayer2);
            Console.Clear();
            int player2Choice = 0;

            switch (choice2)
            {
                case 1:
                    RandomPlayer r2 = new RandomPlayer();
                    player2Choice = r2.GetPlayerBehaviour();
                    break;
                case 2:
                    ConsolePlayer c2 = new ConsolePlayer();
                    player2Choice = c2.GetPlayerBehaviour();
                    break;
                case 3:
                    AlwaysRock ar2 = new AlwaysRock();
                    player2Choice = ar2.GetPlayerBehaviour();
                    break;
                case 4:
                    AlwaysPaper ap2 = new AlwaysPaper();
                    player2Choice = ap2.GetPlayerBehaviour();
                    break;
                case 5:
                    AlwaysScissors s2 = new AlwaysScissors();
                    player2Choice = s2.GetPlayerBehaviour();
                    break;
            }

            string result = GetResult(player1Choice, player2Choice).ToString();

            Console.WriteLine($"Player 1 chose {(PlayerChoice)player1Choice} and Player 2 chose {(PlayerChoice)player2Choice}"); 

            Console.WriteLine(result);
            
            /*ConsoleIO.PrintResult(result);*/
            

        }
        public GameResult GetResult(int playerOneChoice, int playerTwoChoice)
        {
            if (playerOneChoice == playerTwoChoice)
            {
                return GameResult.TIE;
            }

            // player one win conditions
            if ((playerOneChoice == (int)PlayerChoice.ROCK && playerTwoChoice == (int)PlayerChoice.SCISSORS) ||
                (playerOneChoice == (int)PlayerChoice.PAPER && playerTwoChoice == (int)PlayerChoice.ROCK ||
                (playerOneChoice == (int)PlayerChoice.SCISSORS && playerTwoChoice == (int)PlayerChoice.PAPER)))
            {
                return GameResult.PLAYER1WIN;
            }

            return GameResult.PLAYER2WIN;
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
