using System;

namespace NumberGuessingGame
{
    class Program
    {
        private static Random randomInt = new Random();
        private static int SecretNumber = randomInt.Next(1,101);
        static void Main()
        {
            // Store a secret number (randomized with each execution of the program)
            // MOVED RANDOM INT TO PROGRAM CLASS
            // Random randomInt = new Random();
            // int secretNumber = SecretNumber;

            // Store difficulty numbers in variables


            // Display a message to the user
            Console.WriteLine("\t\t\t -------------------------\n\t\t\t   Number Guessing Game!  \n\t\t\t -------------------------");
            Console.WriteLine("\tTry to guess the secret number. (HINT: whole number 1 through 100)\n");

            /*     OLD CODE
            // Prompting user for a difficulty level to select from
            Console.WriteLine("\n\t\t Please select a difficulty:\n1 - Easy (eight guesses)\n2 - Medium (six guesses)\n3 - Hard (four guesses)");
            

            string userSelection = Console.ReadLine() ?? string.Empty;
            int userDifficulty = int.Parse(userSelection!); 
            */

            // Conditional for variable int storage prior to main loop iteration count
            // public int Tries { get; set; }

            int tries;
            do
            {
                 // Prompting user for a difficulty level to select from
                Console.Write("\n\t\t Please select a difficulty:\n1 - Easy (eight guesses)\n2 - Medium (six guesses)\n3 - Hard (four guesses)\n");
                Console.Write("\nDifficulty Number: ");
                if (int.TryParse(Console.ReadLine(), out tries))
                {
                    switch (tries)
                    {
                        case 1:
                            Game(8);
                            break;
                        case 2:
                            Game(6);
                            break;
                        case 3:
                            Game(4);
                            break;
                        default:
                            Console.WriteLine("Please make a valid selection.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number from the given choices.");
                }
            } while (tries < 1 || tries > 3);



// ****************************   MAIN GAME LOOP   ****************************

        static void Game(int totalTries)
        {
            // Give the user selected chances to guess the number.
            for (int i = 0; i < totalTries; i++)
            {

                // Display the number of the user's current guess
                Console.WriteLine($"\t\t\t -------  Guess #{i + 1}  -------\n");

                // Display the number of guesses remaining
                Console.WriteLine($"You have {totalTries-i} guesses remaining.\n");

                // Display a prompt for the user's guess
                Console.Write("Enter your guess: ");

                // Take the user's guess as input and save it as a variable
                string userInput = Console.ReadLine() ?? string.Empty;  // ?? = null-coalescing operator (to fix error message from phase 1)

                // Convert the user input to an integer
                int userGuess = int.Parse(userInput!);  // ! = null-forgiving operator (to fix error message from phase 1)

                // Display the user's guess back to the screen (REMOVED IN PHASE 2)
                // Console.WriteLine($"You guessed: {userGuess}");

                // Display result of guess (right, wrong)
                if (userGuess == SecretNumber) {
                    Console.WriteLine("CORRECT!!! Incredible....how did you know!?\n");
                    Console.WriteLine("\t\t\t****************\n\t\t\t** YOU WIN!!! **\n\t\t\t****************");
                    break;
                }
                else{
                    Console.WriteLine("WRONG!!! I knew my secret number was a good one...");
                }


                // Give user too high / too low hints after each attempt
                if (userGuess > 100 || userGuess < 1)
                {
                    Console.Write("\nYou've wasted your attempt! Please guess a whole number 1 through 100.\n\n");
                }
                else if (userGuess > SecretNumber)
                {
                    Console.Write("\nYour guess is too HIGH...\n\n");
                }
                else if (userGuess < SecretNumber)
                {
                    Console.Write("\nYour guess is too LOW...\n\n");
                }


                // Added a FAIL message after final incorrect attempt
                if (i == totalTries-1 && userGuess != SecretNumber)
                {
                    Console.WriteLine("\t\t\txxxxxxxxxxxxxxxx\n\t\t\txx YOU LOSE!! xx\n\t\t\txxxxxxxxxxxxxxxx");
                    Console.WriteLine($"\n\t\t    The secret number was {SecretNumber}.");
                }

            }

            // Pause to keep the program open
            Console.ReadLine();
          }
        }
    }
}