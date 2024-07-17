using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store a secret number (randomized with each execution of the program)
            Random randomInt = new Random();
            int secretNumber = randomInt.Next(1,101);

            // Display a message to the user
            Console.WriteLine("\t\t\t -------------------------\n\t\t\t   Number Guessing Game!  \n\t\t\t -------------------------");
            Console.WriteLine("\t\tTry to guess the secret number. (HINT: between 1 and 100)\n");


            // Give the user four chances to guess the number.
            for (int i=0; i<4; i++)
            {

                // Display the number of the user's current guess
                Console.WriteLine($"\t\t\t -------  Guess #{i + 1}  -------\n");

                // Display the number of guesses remaining
                Console.WriteLine($"You have {4-i} guesses remaining.\n");

                // Display a prompt for the user's guess
                Console.Write("Enter your guess: ");

                // Take the user's guess as input and save it as a variable
                string userInput = Console.ReadLine() ?? string.Empty;  // ?? = null-coalescing operator (to fix error message from phase 1)

                // Convert the user input to an integer
                int userGuess = int.Parse(userInput!);  // ! = null-forgiving operator (to fix error message from phase 1)

                // Display the user's guess back to the screen (REMOVED IN PHASE 2)
                // Console.WriteLine($"You guessed: {userGuess}");

                if (userGuess == secretNumber) {
                    Console.WriteLine("CORRECT!!! Incredible....how did you know!?\n");
                    Console.WriteLine("\t\t\t****************\n\t\t\t** YOU WIN!!! **\n\t\t\t****************");
                    break;
                }
                else{
                    Console.WriteLine("WRONG!!! I knew my secret number was a good one...\n");
                }
                if (i == 3 && userGuess != secretNumber)
                {
                    Console.WriteLine("\t\t\txxxxxxxxxxxxxxxx\n\t\t\txx YOU LOSE!! xx\n\t\t\txxxxxxxxxxxxxxxx");
                    Console.WriteLine($"\n\t\t    The secret number was {secretNumber}.");
                }

            }
            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}