 //Abstraction with YouTube Videos program from the Foundation 4 option. I have completed the design of the class that tracks YouTube videos and their corresponding comments.
   
using System;
    
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to youtube tutorial videos!");
        Console.WriteLine();

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to JavaScript", "Alex Johnson", 30);
        video1.AddComment("Damon", "Great tutorial!");
        video1.AddComment("Sarah", "JavaScript can be challenging, but this video broke it down nicely!");
        video1.AddComment("Michael", "I learned a lot, thank you!");
        videos.Add(video1);

        Video video2 = new Video("Introduction to Java", "Sarah Thompson", 60);
        video2.AddComment("David", "I learned a lot from this crash course. Highly recommended!");
        video2.AddComment("Charlie", "Well-explained. Can't wait for more videos on this topic!");
        video2.AddComment("Fred", "Clear explanation. Thank you!");
        videos.Add(video2);

        Video video3 = new Video("Web Development Basics", "Emily Wilson", 40);
        video3.AddComment("Greg", "Thanks for sharing!");
        video3.AddComment("Alex", "I enjoyed the practical examples. Thanks for sharing your expertise!");
        video3.AddComment("Fred", "Great job.");
        videos.Add(video3);

        Video video4 = new Video("Machine Learning Fundamentals", " David Lee", 20);
        video4.AddComment("Jacob", "This video inspired me to dive deeper into machine learning. Thank you!");
        video4.AddComment("Grace", "The examples were really helpful. Thanks for sharing!");
        video4.AddComment("Harley", "This was so good!");
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine("--------");
            Console.WriteLine();
        }

    }
}