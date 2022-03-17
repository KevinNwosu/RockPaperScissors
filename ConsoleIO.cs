namespace RockPaperScissors
{
    public class ConsoleIO
    {
        public static int PromptPlayerType(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("1. Random Picker");
            Console.WriteLine("2. Console Picker");
            Console.WriteLine("3. Always Rock");
            Console.WriteLine("4. Always Paper");
            Console.WriteLine("5. Always Scissors");

            while (true)
            {
                Console.Write("Enter Choice: ");

                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input < 1)
                    {
                        Console.WriteLine("Number must be positive.");
                    }
                    else if (input > 5)
                    {
                        Console.WriteLine("Number not in range");
                    }
                    else
                    {
                        return input;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input enter a number please.");
                }

            }
        }
        public static void PrintResult(int result)
        {
            if (result == 1)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (result == 2)
            {
                Console.WriteLine("Congratulations Player 1, you win!");
            }
            else if (result == 3)
            {
                Console.WriteLine("Congratulations Player 2, you win!");
            }
        }
        public static int GetConsolePlayerInput()
        {
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            while (true)
            {
                Console.Write("Enter Choice: ");

                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input < 1)
                    {
                        Console.WriteLine("Number must be positive.");
                    }
                    else if (input > 3)
                    {
                        Console.WriteLine("Number not in range");
                    }
                    else
                    {
                        return input;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input enter a number please.");
                }

            }
        }
    }
}
