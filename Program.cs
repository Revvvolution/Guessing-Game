using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store a secret number
            int secretNumber = 42;

            // Display a message to the user
            Console.WriteLine(" -------------------------\n   Number Guessing Game!  \n -------------------------");
            Console.WriteLine("Try to guess the secret number.\n");

            // Display a prompt for the user's guess
            Console.Write("Enter your guess: ");

            // Take the user's guess as input and save it as a variable
            string userInput = Console.ReadLine();

            // Convert the user input to an integer
            int userGuess = int.Parse(userInput);

            // Display the user's guess back to the screen
            Console.WriteLine($"You guessed: {userGuess}");

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}