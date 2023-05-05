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

        //string _userInput = PromptUserInput();
        string _fileName;
        string _randomPrompt;
        string _promptResponse;
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
        return userInput;
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