using System;

class Program
{ 
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); // list to store the numbers
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine()); 
            if (number != 0)
            {
                numbers.Add(number); // Add the number to the list if it is not zero
            }
        } while (number != 0); 

        Console.WriteLine("The sum is: " + numbers.Sum()); // display the sum of the numbers
        Console.WriteLine("The average is: " + numbers.Average()); // display the average of the numbers
        Console.WriteLine("The largest number is: " + numbers.Max()); // display the largest number in the list

        
        if (numbers.Any(n => n > 0))
        {
            Console.WriteLine("The smallest positive number is: " + numbers.Where(n => n > 0).Min()); // display the smallest positive number
        }

        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList(); // the numbers in ascending order
        Console.WriteLine("The sorted list is:");
        foreach (int sortedNumber in sortedNumbers)
        {
        Console.WriteLine(sortedNumber); // Display each number in the sorted list
        }
    } 
}