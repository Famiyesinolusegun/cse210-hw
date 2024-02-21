//Inheritance with Event Planning program from the Foundation 4 option.creating classes for different types of events like lecture, reception, and outdoor gathering. These classes effectively capture essential details such as the event title, description, date, time, and address.
 
using System;

class Program
{
    static void Main()
    { 
        Console.WriteLine("Welcome to events planner !");

        // Creating an instance of Lecture
        Address lectureAddress = new Address("123 Main Street", "Cityville", "Stateville", "Countryland");
        Lecture lecture = new Lecture("Introduction to Programming", "Learn the basics of programming", DateTime.Now, new TimeSpan(14, 30, 0), lectureAddress, "Jane Smith", 100);
        
        // Creating an instance of Reception
        Address receptionAddress = new Address("789 Oak Avenue", "Cityville", "Countyville", "Countryland");
        Reception reception = new Reception("Tech Networking Event", "Connect with professionals in the tech industry", DateTime.Now.AddDays(1), new TimeSpan(19, 0, 0), receptionAddress, "rsvp@eventtech.com");
        
        // Creating an instance of OutdoorGathering
        Address gatheringAddress = new Address("123 Beach Road", "Seaside", "Countyville", "Countryland");
        OutdoorGathering gathering = new OutdoorGathering("Summer BBQ", "Enjoy a fun-filled BBQ party by the beach", DateTime.Now.AddDays(2), new TimeSpan(15, 0, 0), gatheringAddress, "Sunny");

        // Displaying event details 
        Console.WriteLine("\n-------------------");
        Console.WriteLine(lecture.GetMessage()); 
        Console.WriteLine("\n-------------------");
        Console.WriteLine(reception.GetMessage()); 
        Console.WriteLine("\n-------------------");
        Console.WriteLine(gathering.GetMessage()); 
        Console.WriteLine("---------------------------\n");
    } 
}