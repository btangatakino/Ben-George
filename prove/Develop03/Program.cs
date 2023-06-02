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
        /*Scriptures scripture = new Scriptures("Proverbs", 3, 5, 6,"Trust in the Lord with all thine heart; and lean not unto thine own understaing. In all thy ways, aknowledge him, and he shall direct thy paths.");*/
        Scriptures scripture = new Scriptures("Moses", 1, 39,"For behold, this is my work and my glory-to bring to pass the immortality and eternal life of man.");
        do
        {   
            Console.Clear();            
            scripture.Reference.GetReference();
            scripture.Display();
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
