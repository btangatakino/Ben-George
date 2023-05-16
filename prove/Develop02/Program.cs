using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This program is to help people record events of their day
by supplying prompts and then saving their responses along 
with the question and the date to a file */
public class Entry
{
    public string _dateTimeEntry;

    public string _entryPrompt;

    public string _entryResponse;

    public string DateTimeEntry()
    {
        //set date and time
        DateTime timeOfEntry = DateTime.Now;
        string dateTime = timeOfEntry.ToShortDateString();
        return dateTime;
    }

    public void DisplayUserEntry()
    {
        Console.WriteLine($"{_dateTimeEntry} {_entryPrompt} {_entryResponse}");
    }
}

public class PromptGenerator
{
    List<string> _promptsList = new List<string>
    {
        "What is one memorable thing that happened today?",
        "Share an experience of Service today.",
        "Did you speak kind words to someone today?",
        "How have you seen the Lord's hand in your life today?",
        "Name an interesting person you met today and how?"
    };
    public void DisplayPrompts()
    {
        Console.WriteLine($"{_promptsList}");
    }
    Random ran = new Random();
    public void GeneratePrompt()
    {
        int myIndex = ran.Next(_promptsList.Count);         
        Console.WriteLine(_promptsList[myIndex]);
        Console.ReadLine();
    }    
}
public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void DisplayEntryList()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayUserEntry();
        }
    }
        public void SaveToFile()
    {
        List<Entry> entry = new List<Entry>();
        Console.WriteLine("Saviing to file...");
        Console.WriteLine("Enter a filename for your entry.");

        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry ent in entry)
            {
                outputFile.WriteLine("{ent}");
            }
        }
    }
    /*public void List<Entry> ReadFromFile()
    {
        List<Entry> entry = new List<Entry>();
        string filename = "journal.txt";

        return entry;
    }*/
    
}
partial class Program
{
    static void Main(string[] args)
    {
        PromptGenerator genPrompt = new PromptGenerator();
        genPrompt.DisplayPrompts();
    
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        }

        static int PromptUserInput()
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
                //The program will select from a number of random 
                //prompts and display one to the user
                PromptGenerator gPrompt = new PromptGenerator();
                gPrompt.GeneratePrompt();
                string promptResponse = Console.ReadLine();
                Entry entry = new Entry();
                string date = entry.DateTimeEntry();
                //entry._entryPrompt = gprompt.GeneratePrompt();
                entry._entryResponse = promptResponse;
                entry._dateTimeEntry = date;

                Journal journalEntry = new Journal();
                //journalEntry._entries.Add(entry);
                break;

            case 2:
                Console.WriteLine("Need to call the Display Method.");
                //The program will display all the entries inside the journal
                //Journal journalEntry = new Journal();
                
                Journal journal = new Journal();
                journal.DisplayEntryList();
                break;

            case 3:
                Console.WriteLine("Need to call the Load Method");
                break;

            case 4:
                Console.WriteLine("Need to call the Save Method");
                //journal.SaveToFile();
                break;

            default:
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;
            }

            return userInput;
        }
        DisplayWelcomeMessage();
        PromptUserInput();
    }
}