using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string userValue = "";
        Scriptures scripture;
        RandomScripture ranscript = new RandomScripture();

        Console.WriteLine("Welcome to the Scripture Memorizer Program!");

        while (true)
        {
            Console.WriteLine("1) Choose a Scripture to memorize.");
            Console.WriteLine("2) Quit");
            Console.WriteLine("\nType 1 to continue or type 2 or 'quit' to finish:");
            userValue = Console.ReadLine();
            if (userValue == "1")
            {
                Console.Clear();
                
                scripture = ranscript.GenerateScripture();
                do
                {
                    Console.Clear();
                    scripture.Reference.GetReference();
                    scripture.Display();
                    Console.WriteLine();
                    Console.WriteLine("\nPress enter to continue or type 'quit' to choose another scripture:");
                    userValue = Console.ReadLine();
                    if (scripture.AllWordsHidden())
                        break;
                    for (int x = 0; x < 3; x++)
                    {
                        bool status;
                        do
                        {
                            status = scripture.HideWord();
                        }
                        while (!status && !scripture.AllWordsHidden());
                    }
                }
                while (userValue.ToLower() != "quit");
            }
            else
                break;
        }
        Console.WriteLine("Thank you for using the Scripture Memorizer Prograrm!");
    }
}