using System;

/*This program is to help people record events of their day
by supplying prompts and then saving their responses along 
with the question and the date to a file */

class Journal
{
    //adding comments
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        int _userInput = PromptUserInput();
        //String _fileName;
        //string _randomPrompt;
        //string _promptResponse;

        Entry myEntry = new Entry();

        myEntry._dateOfEntry = "29 April 1970";
        myEntry._promptQuestion = "What interesting event happened to you on that day?";
        myEntry._promptResponse = "I was born on that day.";
        //myEntry.Display();
    }
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
        int userInput = int.Parse(Console.ReadLine());
        //return userInput;
    
        if(userInput == 1)
        {
            Console.WriteLine("You have selected the Write option");
        }
        else if(userInput == 2)
        {
            Console.WriteLine("You have selected the Display option");
            myEntry.Display();
        }
        else if(userInput == 3)
        {
            Console.WriteLine("You have selected the Load option");
        }
        else if(userInput == 4)
        {
            Console.WriteLine("You have selected the Save option");
        }
        else if(userInput == 5)
        {
            Console.WriteLine("You have selected the Quit option");
        }
        return userInput;        
    }

    public class Entry
    {
        //public string _listOfEntries;

        //public string _dateOfEntry = "29th April 1970";
        public string _dateOfEntry;

        //public string _promptResponse = "I was born on that day.";
        public string _promptResponse;

        //public string _promptQuestion = "What interesting event happened to you on that day?" ;
        public string _promptQuestion;
        
        public void Display()
        {
            Console.WriteLine($"{_dateOfEntry} {_promptQuestion} {_promptResponse}");
        }
    }
}      

        /*
        //some method here
        private List<Entry> _entries = new List<Entry>();
        }

        class Entry
        {
            //some methods here
        }

        class PromptGenerator
        {
            //some methods here
        }
    }
}*/