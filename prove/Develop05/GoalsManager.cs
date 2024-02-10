using System;
using System.Collections.Generic;

public class GoalsManager
{
    private List<Goal> goals;

    public GoalsManager()
    {
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void MarkAllGoalsComplete()
    {
        foreach (Goal goal in goals)
        {
            goal.MarkComplete();
        }
    }

    public void DisplayAllGoals()
    {
        foreach (Goal goal in goals)
        {
            goal.DisplayProgress();
        }
    }

    public void SaveGoalsToFile(string filename)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
}