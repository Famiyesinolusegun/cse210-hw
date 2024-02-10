using System;

public abstract class Goal
{
    protected string name;
    protected int value;

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
    }

    public abstract void MarkComplete();
    public abstract void DisplayProgress();
    public abstract string GetType();
    public abstract string GetStringRepresentation();
}