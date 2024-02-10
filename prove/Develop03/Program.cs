
//Exceeds the requirement add "Library.cs" that store different scriptures according to the user selection from the list.and let the user to select how many words to hide on each round.
 
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to Scripture Memorizer");
        Console.WriteLine("Please select a scripture from the list: ");
        Console.WriteLine("1. Genesis 1:1-3");
        Console.WriteLine("2. John 3:16");
        Console.WriteLine("3. Romans 8:28-30");
        Console.WriteLine("4. Psalms 23:1-6");
        int option = int.Parse(Console.ReadLine());

        Library selection = new Library();
        selection.SetScripture(option);

        Reference choice = new Reference(selection.GetBook(), selection.GetChapter(), selection.GetStartVerse(), selection.GetEndVerse());
        Scripture scripture = new Scripture(choice, selection.GetScriptureText());

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
        } while (!scripture.IsCompletelyHidden());

        Console.WriteLine("\nAll words hidden. Press any key to exit...");
        Console.ReadKey();
    }
}