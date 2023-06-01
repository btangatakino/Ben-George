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
        
        //Console.Clear();  
        //This part is working
        
        //This part is working for scripture.Display
        Scriptures scripture = new Scriptures("Proverbs", 3, 5, 6,"Trust in the Lord in the Lord with all thine heart; and lean not unto thine own understaing. In all thy ways, aknowledge him, and he shall direct thy paths.");
        do
        {   
            Console.Clear();
            scripture.Display();
            scripture.Reference.GetReference();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");      
            userValue = Console.ReadLine();
            if(scripture.AllWordsHidden())
                break;
            for(int x = 0; x <3; x++)
            {
                bool status;
                do
                {
                    status = scripture.HideWord();
                }
                while(!status);
            }
            
            
        }
        while(userValue.ToLower() != "quit");
    }
}    
