using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override void MarkComplete()
    {
        Console.WriteLine($"Eternal goal '{name}' recorded!");
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"Eternal goal '{name}' progress: [ ]");
    }

    public override string GetType()
    {
        return "Eternal";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType()}:{name}";
    }
}