using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is the one thing you did today to be closer to your goals?",
        "What did you learn today?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
        return prompts[index];
    }
}