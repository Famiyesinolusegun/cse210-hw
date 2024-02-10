using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value) { }

    public override void MarkComplete()
    {
        Console.WriteLine($"Simple goal '{name}' marked as complete!");
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"Simple goal '{name}' progress: [X]");
    }

    public override string GetType()
    {
        return "Simple";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType()}:{name}";
    }
}