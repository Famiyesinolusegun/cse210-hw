  
//Exceeds the requirement Added meaningful animation and Saving and loading a log file.
using System;
class Program
{
 
   
       static void Main(string[] args)

{
    Console.WriteLine("Welcome to the Mindfulness Activity");

    bool exitRequested = false;

    do
    {
        Console.Clear(); // Clear the terminal
        Console.WriteLine("\nChoose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Load Activity");
        Console.WriteLine("5. Exit");

        Console.Write("Enter your choice (1-5): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                PerformBreathingActivity();
                break;
            case "2":
                PerformReflectionActivity();
                break;
            case "3":
                PerformListingActivity();
                break;
            case "4":
                Logger.LoadLog();
                break;
            case "5":
                exitRequested = true;
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                break;
        }

    } while (!exitRequested);

    Console.WriteLine("Thank you ");


    static void PerformBreathingActivity()
{
    Console.Clear(); // Clear the terminal
    BreathingActivity breathingActivity = new BreathingActivity();
    breathingActivity.DoBreathingActivity();
    Logger.Log("Performed Breathing Activity");
}

static void PerformReflectionActivity()
{
    Console.Clear(); // Clear the terminal
    ReflectionActivity reflectionActivity = new ReflectionActivity();
    reflectionActivity.DoReflectionActivity();
    Logger.Log("Performed Reflection Activity");
}

static void PerformListingActivity()
{
    Console.Clear(); // Clear the terminal
    ListingActivity listingActivity = new ListingActivity();
    listingActivity.DoListingActivity();
    Logger.Log("Performed Listing Activity");
} 
} 
}