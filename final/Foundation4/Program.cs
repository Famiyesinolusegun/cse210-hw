 //Polymorphism with Exercise Tracking program from the Foundation 4 option. creating classes for running,cycling, and swimming. The classes are capable of tracking essential details such as the date, duration.
 
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracker!");

        Activity runningActivity = new Running(new DateTime(2024, 2, 2), 20, 3.0);
        Activity cyclingActivity = new Cycling(new DateTime(2024, 1, 24), 40, 10);
        Activity swimmingActivity = new Swimming(new DateTime(2024, 1, 15), 60, 50);

        Activity[] activities = { runningActivity, cyclingActivity, swimmingActivity };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            
        }

    }
}