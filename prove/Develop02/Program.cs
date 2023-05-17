using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
/*This program is to help people record events of their day
by supplying prompts and then saving their responses along 
with the question and the date to a file */

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