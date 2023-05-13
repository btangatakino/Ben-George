using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Journal
{
    public static List<Entry> _entries = new List<Entry>();

    public void DisplayWelcomeMessage()
    {
        Entry p1 = new Entry();
        p1._dateOfEntry = "29th April 1970";
        p1._entryPrompt = "What happened on this day?";
    }
}
    
    /*    Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");        
    }

public static int PromptUserInput()
{
    Console.WriteLine("What would you like to do?");
    int userInput;
    while (!int.TryParse(Console.ReadLine(), out userInput))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }

    switch (userInput)
    {
        case 1:
            Console.WriteLine("Need to call the Entry or Write Method");
            break;

        case 2:
            Console.WriteLine("Need to call the Display Method.");
            break;

        case 3:
            Console.WriteLine("Need to call the Load Method");
            break;

        case 4:
            Console.WriteLine("Need to call the Save Method");
            break;

        default:
            Environment.Exit(0);
            break;
    }

    return userInput;
}
    private void GeneratePrompt()
    {
        throw new NotImplementedException();
    }
    List<Entry> entries = new List<Entry>();
    entries
    public static void  SaveToFile(List<Person> people)
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{fileName}");
        }
    }
}*/