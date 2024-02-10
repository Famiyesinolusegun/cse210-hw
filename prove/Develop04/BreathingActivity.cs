using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "The breathing activity will help you relax your mind through breathing in and out slowly")
    {
    }

    public void DoBreathingActivity()
    {
        StartActivity();
        for (int i = 0; i < duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2);
            Console.WriteLine("Breathe out...");
            ShowSpinner(2);
        }
        EndActivity();
    }
}

