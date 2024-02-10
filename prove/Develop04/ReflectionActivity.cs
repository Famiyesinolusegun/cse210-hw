using System;

class ReflectionActivity : Activity
{
    private string[] prompts;
    private string[] questions = {
      "Why did this experience hold significance for you?",
      "Have you previously engaged in a similar activity?",
      "What prompted you to initiate this endeavor?",
      "What were your emotions upon its completion?",
      "What differentiates this instance from previous, less successful attempts?",
      "What aspect of this experience do you appreciate the most?",
      "What insights can you draw from this encounter that can be applicable to other circumstances?",
      "What self-discoveries did you make during this experience?",
      "How can you incorporate the lessons from this experience into your future endeavors?"
    };

    public ReflectionActivity() : base("Reflection Activity", "The Reflection activity will help you reflect on times you show Inner strength and tenacity..")
    {
        prompts = new string[] {
            "Remember a time you stood up for someone.",
            "Think of a difficult task you accomplished.",
            "Recall a time when you helped someone in need.",
            "Reflect on a moment of true selflessness."
        };
    }

    public void DoReflectionActivity()
    {
        StartActivity();
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine(prompt);
        ShowSpinner(3);

        foreach (var question in questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        EndActivity();
    }
}
