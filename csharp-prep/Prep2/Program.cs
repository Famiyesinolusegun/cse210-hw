using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter your grade percentage:");
       string input = Console.ReadLine();
        int Percentage = int.Parse(input);

        string letter = ""; // variable to store the letter grade

        if (Percentage >= 90)
        {
            letter = "A"; 
        }
        else if (Percentage >= 80)
        {
            letter = "B"; 
        }
         else if (Percentage >= 70)
        {
            letter = "C";  
        }    
        else if (Percentage >= 60)
        {
            letter = "D"; 
        }
        else
        {
            letter = "F"; 
        }

        Console.WriteLine("Your letter grade is: " + letter);

        if (Percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course."); // If the Percentage is 70 or above, display this message
        }
        else
        {
            Console.WriteLine("Good luck next time."); // If the Percentage is below 70, display this message
        }     
    }     
}