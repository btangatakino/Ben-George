using System;
using System.Collections.Generic;

/*This program is to help people record events of their day
by supplying prompts and then saving their responses along 
with the question and the date to a file */

class Program

{
    //adding comments
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        journal.displayWelcomeMessage();

        //int _userInput = promptUserInput();
        //String _fileName;
        //string _randomPrompt;
        //string _promptResponse;
        
        //public List<Entry> _myEntry = new List<Entry>();

        Entry myEntry = new Entry();

        myEntry._dateOfEntry = "29 April 1970";
        myEntry._promptQuestion = "What interesting event happened to you on that day?";
        myEntry._promptResponse = "I was born on that day.";
        myEntry.Display();

        /*List<String> _prompts = new List<String>();

        _prompts.Add("What is one memorable thing that happened today?");
        _prompts.Add("Name an interesting person you met today and how?");
        _prompts.Add("Share an experience of Service today.");
        _prompts.Add("Did you speak kind words to someone today?");
        _prompts.Add("How have you seen the Lord's hand in you life today?");

        foreach(String item in _prompts)
        {
            Console.WriteLine(item);
        }*/
        Console.ReadKey();
    } 
    /*static void DisplayWelcomeMessage()
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
            //myInput.Display();
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
    }*/
}

    /*public class Input
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