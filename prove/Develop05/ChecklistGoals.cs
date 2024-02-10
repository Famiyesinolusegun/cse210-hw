using System;

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
    }

    public override void MarkComplete()
    {
        currentCount++;
        Console.WriteLine($"Checklist goal '{name}' recorded!");

        if (currentCount == targetCount)
        {
            value += 500;
            Console.WriteLine($"Bonus points awarded for completing checklist goal '{name}'!");
        }
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"Checklist goal '{name}' progress: [{currentCount}/{targetCount}]");
    }

    public override string GetType()
    {
        return "Checklist";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType()}:{name}:{targetCount}:{currentCount}";
    }
}