using System;

class Program
{
    
    static void Main(string[] args)
        {
            DisplayWelcome(); 
            string userName = PromptUserName(); 
            int userNumber = PromptUserNumber(); 
            int squaredNumber = SquareNumber(userNumber); 
            DisplayResult(userName, squaredNumber); 
        }

        // Function to display a welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Function to prompt the user for there name 
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        // Function to prompt the user for their favorite number 
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        // Function to square the favorite number 
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }

        // Function to display the user's name and squared favorite number
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }      
        
}