using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string userValue;
        //ConsoleKeyInfo click;
        do
        {
            //Console.Clear();  
            //This part is working
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            reference.GetReference();

            //This part is working for scripture.Display
            Scriptures scripture = new Scriptures(@"Trust in the Lord in the Lord with all thine heart; and lean not unto thine own understaing. In all thy ways, aknowledge him, and he shall direct thy paths.");
            //scripture.GetText();
            //scripture.RandomVerse();
            //scripture.Display();

            Word word1 = new Word();
            //word1.HideWords();
            //scripture.GetText();
            scripture.GetVerse();
            //Console.WriteLine(scripture.GetText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            //Console.Clear();
            userValue= Console.ReadLine();
            Console.Clear();
            /*
            do
            {
                Console.Clear();
                reference1.GetReference1();
                scripture.GetText2();
                click = Console.ReadKey();
            }
            while (click.Key != ConsoleKey.Enter);*/

            //Scriptures scripture2 = new Scriptures("this is for testing only");
            //Console.WriteLine(scripture2.GetText());
            //Console.Clear();
        }
        while(userValue.ToLower() != "quit");
    }
}    
