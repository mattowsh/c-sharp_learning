using System;
using System.Text;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game performance:
            bool keepGoing = true;

            // Start message:
            Console.WriteLine("Let's begin:");
            
            do {
                string userInput = Console.ReadLine();

                if (userInput == "exit") {
                    keepGoing = false;
                }
                else {
                    (bool, int) result = IsPalindrome(userInput.ToUpper());
                    Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");
                }
            } while (keepGoing);
        }

        static (bool, int) IsPalindrome(string userInput)
        {
            // Flags to move on the string:
            int i, j;
            // Palindrome status:
            bool status = true;

            // New string result, only letters:
            var stringResult = new StringBuilder();
            foreach (char letter in userInput) {
                if (!char.IsPunctuation(letter) && !char.IsWhiteSpace(letter))
                    stringResult.Append(letter);
            }
            userInput = stringResult.ToString();
            
            // Check each char in the user input:
            for (i = 0, j = userInput.Length - 1; i <= j; i++, j--)
            {
                if (userInput[i] != userInput[j])
                    return (false, 0);
            }
            return(status, userInput.Length);
        }
    }
}
