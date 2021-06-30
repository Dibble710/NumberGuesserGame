using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Print out the app version and creator to the console

            GetUserInfo(); // Get the user's name, and greet the user.

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

                    if (!int.TryParse(input, out guess) || !(guess > 0 && guess <= 10))
                    {
                        Response invalidResponse = new Response(ConsoleColor.Red, "Please enter a valid number between 1 and 10!");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    // Match Guess To Correct Number // 

                    if (guess != correctNumber)
                    {
                        Response incorrectResponse = new Response(ConsoleColor.Red, "Guess again!");
                    }
                }

                // Success Message // 

                Response correctResponse = new Response(ConsoleColor.Yellow, "Congrats, you are CORRECT!!!");
                Console.ResetColor();

                // Play Again Prompt // 

                Response playAgain = new Response(ConsoleColor.Green, "Do you want to play again? [Y or N]");
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
                // End Application // 
            }
        }

        static void GetAppInfo()
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.1";
            string appAuthor = "Tyler Antoni";

            // Start Header // 
            Response greeting = new Response(ConsoleColor.Cyan, $"{appName}: Version {appVersion} by {appAuthor}");
            Console.ResetColor();
            // End Header //
        }

        static void GetUserInfo()
        {
            Console.WriteLine("What is your name?");

            string usersName = Console.ReadLine();
            Console.WriteLine($"Hello {usersName} let's play a game!");
        }
    }
}