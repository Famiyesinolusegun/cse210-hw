using System;

class ListingActivity : Activity
{
    private string[] prompts;
    public ListingActivity() : base("Listing Activity", "The listing activity will help you reflect on the good things by listing them")
    {
        prompts = new string[] {
            "What are your strengths?",
            "Who do you admire?",
            "When did you feel spiritually connected?",
            "Whom have you helped recently?",
            "Who are your personal heroes?"
        };
    }

    public void DoListingActivity()
    {
        StartActivity();
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine(prompt);
        Console.WriteLine("You have several seconds to think about the prompt...");
        ShowSpinner(5);

        Console.WriteLine("Start listing:");

        for (int i = 0; i < duration; i++)
        {
            Console.Write("list: ");
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
            {
                break;
            }
        }

        Console.WriteLine($"You listed {duration}.");
        EndActivity();
    }
}
