using System;
using System.Text;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose the random number:
            int numberToDiscover = new Random().Next(20);

            // Print instructions:
            Console.WriteLine("Let's play 'Guess the Number'!");
            Console.WriteLine("I'm thinking in of a number between 0 and 20'");
            Console.WriteLine("Enter yout guess, or -1 to give up :)");

            // Check qty of user guesses:
            int qtyGuesses = 0;
            // Create a variable to save the user input:
            int userInput = 0;

            // Check user inputs:
            do {
                Console.WriteLine("What's your guess?");
                string userGuess = Console.ReadLine();

                // Check if userGuess can be parsed into int value:
                bool guessResult = int.TryParse(userGuess, out userInput);
                if (!guessResult) {
                    Console.WriteLine("That doesn't look like a number. Try again!");
                }
                
                // Exit condition:
                if (userInput == -1) {
                    Console.WriteLine($"Oh well. I was thinking of {numberToDiscover}");
                    return;
                } 
                
                // Out of range condition:
                else if (userInput > 20 || userInput < 0) {
                    Console.WriteLine("The numbes has to be between 0 and 20");
                    qtyGuesses++;

                // Discovered condition:
                } else if (userInput == numberToDiscover) {
                    qtyGuesses++;
                    Console.WriteLine($"Yout got it in {qtyGuesses} guesses!");
                    return;
                }
                
                // Other number condition:
                else {
                    Console.WriteLine("Nope, {0} than that", userInput < numberToDiscover ? "higher" : "lower");
                    qtyGuesses++;
                }
            } while (true);
        }
     }
}
