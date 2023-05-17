using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
/*This program is to help people record events of their day
by supplying prompts and then saving their responses along 
with the question and the date to a file */
/*public class Entry
{
    public string _dateTimeEntry;

    public string _entryPrompt;

    public string _entryResponse;

    public Entry(string entryPrompt, string entryResponse)
    {
        // Gets the prompt and stores it in a Variable (As a String)
        _entryPrompt = entryPrompt;
        // Gets the user Entry and stores in in a Variale (As a String)
        _entryResponse = entryResponse.Replace(",", "|");
        // Gets the date and stores it in a Variable
        _dateTimeEntry = DateTime.Now.ToString("MM/dd/yyyy");
    }
    public void DisplayUserEntry()
    {
        Console.WriteLine($"{_dateTimeEntry} {_entryPrompt} {_entryResponse}");
    }
}
public class PromptGenerator
{
    public string _displayPrompt;
    public void RandomPrompt()
    {
        List<string> promptsList = new List<string>();
        promptsList.Add("What is one memorable thing that happened today?");
        promptsList.Add("Share an experience of Service today.");
        promptsList.Add("Did you speak kind words to someone today?");
        promptsList.Add("How have you seen the Lord's hand in your life today?");
        promptsList.Add("Name an interesting person you met today and how?");

        Random random = new Random();
        int myIndex = random.Next(promptsList.Count);
        _displayPrompt = promptsList[myIndex];
        Console.WriteLine(_displayPrompt);
    }
}
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayEntryList()
    {
        foreach (Entry entry in _entries)
        {
        Console.WriteLine($"{entry._dateTimeEntry}, {entry._entryPrompt}, {entry._entryResponse}");
        }
    }
    
    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saviing to file...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._dateTimeEntry}, {entry._entryPrompt}, {entry._entryResponse}");
            }
        }
    }
    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string savedEntry = parts[1];
            // Pulls the prompt used to prompt the entry and store it in a variable
            Entry entry = new Entry(parts[2], savedEntry.Replace("|", ","));
            // pulls the date from the entry, and stores it in a variable
            entry._dateTimeEntry = parts[0];
            // adds the entries to the list. 
            _entries.Add(entry);
        }

    }
}*/
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator genPrompt = new PromptGenerator();

        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        static string DisplayWelcomeMessage()
        {
            //Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            string userInput = Console.ReadLine();
            return userInput;
        }
        string userInput = "";

        while (userInput != "5")
        {
            userInput = DisplayWelcomeMessage();
            switch (userInput)
            {
                case "1":
                    genPrompt.RandomPrompt();
                    Entry entry = new Entry(genPrompt._displayPrompt, Console.ReadLine());
                    journal._entries.Add(entry);
                    break;

                case "2":                    
                    journal.DisplayEntryList();
                    break;

                case "3":
                    Console.WriteLine("What is the filename?");
                    string userFilename;
                    userFilename = Console.ReadLine();
                    journal.ReadFromFile(userFilename);
                    break;

                case "4":
                    Console.WriteLine("What is the filename?");
                    string userFile;
                    userFile = Console.ReadLine();
                    journal.SaveToFile(userFile);
                    break;

                case "5":
                    Console.WriteLine("Have a good day!");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    break;
            }
        }
    }
}