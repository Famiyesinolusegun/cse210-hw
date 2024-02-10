   
//Exceeds the requirement Add leveling up when the user goals it get bonuses 
  
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalsManager goalsManager = new GoalsManager();
        User user = new User();

        Console.WriteLine("Welcome to the Goals Manager!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("1. Add a goal");
            Console.WriteLine("2. Mark all goals as complete");
            Console.WriteLine("3. Display all goals");
            Console.WriteLine("4. Save goals to a file");
            Console.WriteLine("5. Level up");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddGoal(goalsManager);
                    user.AddXP(10); // Earn 10 XP for adding a goal
                    break;
                case "2":
                    goalsManager.MarkAllGoalsComplete();
                    Console.WriteLine("All goals marked as complete!");
                    user.AddXP(20); // Earn 20 XP for marking all goals as complete
                    break;
                case "3":
                    goalsManager.DisplayAllGoals();
                    break;
                case "4":
                    SaveGoalsToFile(goalsManager);
                    break;
                case "5":
                    user.LevelUp();
                    Console.WriteLine("Congratulations! You leveled up to level " + user.Level);
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.ReadLine();
    }

    static void AddGoal(GoalsManager goalsManager)
    {
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the goal value: ");
        int value = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                Goal simpleGoal = new SimpleGoal(name, value);
                goalsManager.AddGoal(simpleGoal);
                Console.WriteLine("Simple goal added!");
                break;
            case "2":
                Goal eternalGoal = new EternalGoal(name, value);
                goalsManager.AddGoal(eternalGoal);
                Console.WriteLine("Eternal goal added!");
                break;
            case "3":
                Console.Write("Enter the target count: ");
                int targetCount = int.Parse(Console.ReadLine());

                Goal checklistGoal = new ChecklistGoal(name, value, targetCount);
                goalsManager.AddGoal(checklistGoal);
                Console.WriteLine("Checklist goal added!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    static void SaveGoalsToFile(GoalsManager goalsManager)
    {
        Console.Write("Enter the filename to save the goals: ");
        string filename = Console.ReadLine();

        goalsManager.SaveGoalsToFile(filename);

        Console.WriteLine("Goals saved to file.");
    }
}

public class User
{
    public int Level { get; private set; }
    private int experiencePoints;

    public User()
    {
        Level = 1;
        experiencePoints = 0;
    }

    public void AddXP(int xp)
    {
        experiencePoints += xp;
        Console.WriteLine("You earned " + xp + " XP!");
        
        // Level up if enough XP is accumulated
        if (experiencePoints >= Level * 100)
        {
            Level++;
            Console.WriteLine("Congratulations! You leveled up to level " + Level);
        }
    }

    public void LevelUp()
    {
        Level++;
        Console.WriteLine("Congratulations! You leveled up to level " + Level);
    }
}