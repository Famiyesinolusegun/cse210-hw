using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random(); // Create a Random object to generate random numbers
        string playAgain = "yes"; // Initialize the playAgain variable with "yes"

        while (playAgain.ToLower() == "yes") // Loop as long as the user wants to play again
        {
            int magicNumber = random.Next(1, 101); // Generate a random number between 1 and 100
            int guess;
            int numberOfGuesses = 0; // Initialize the numberOfGuesses variable with 0

            Console.WriteLine("what is The Magic Number? "); 

            do
            {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine()); 
            numberOfGuesses++; 
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guess != magicNumber); // Continue the loop until the guess matches the magicNumber

            Console.WriteLine("Congratulations! You guessed the number in " + numberOfGuesses + " tries.");

            Console.WriteLine("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine(); // input to determine if the user want to play again
        }
    }
    
}