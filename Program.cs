using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.1";
            string appAuthor = "Tyler Antoni";

            // Start Header // 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");
            Console.ResetColor();
            // End Header //


            // Begin Questions // 
            Console.WriteLine("What is your name?");

            string usersName = Console.ReadLine();
            Console.WriteLine($"Hello {usersName} let's play a game!");

            while (true)
            {
                // Init Correct Number Var //

                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Init Guess Var //
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Please enter a valid number between 1 and 10!");
                        Console.ResetColor();
                        continue;
                    }

                    guess = Int32.Parse(input);

                    // Match Guess To Correct Number // 

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, please try again.");
                        Console.ResetColor();
                    }
                }

                // Success Message // 

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Congrats {usersName} you are CORRECT!!!");
                Console.ResetColor();

                // End Application
                // Console.ForegroundColor = ConsoleColor.Green;
                // Console.WriteLine("Press any key to continue ...");

                // Play Again // 

                Console.WriteLine("Do you want to play again? [Y or N]");
                string response = Console.ReadLine().ToUpper();
                if (response == "Y")
                {
                    continue;
                }
                else if (response == "N")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter a valid response.");
                }
            }
        }
    }
}