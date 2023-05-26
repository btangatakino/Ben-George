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
            Console.Clear();  
            //This part is working
            Reference reference = new Reference();
            reference.GetReference();

            //This part is working
            Scriptures scripture = new Scriptures();
            scripture.GetText();
            Console.Clear();
            //scripture.GetText();
            //Console.WriteLine(scripture.GetText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            //Console.ReadKey();

            //Console.Clear();
            userValue= Console.ReadLine();
            /*do
            {
                Console.Clear();
                reference1.GetReference1();
                scripture.GetText2();
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                //click = Console.ReadKey();
            }
            while (click.Key != ConsoleKey.Enter);*/

            //Scriptures scripture2 = new Scriptures("this is for testing only");
            //Console.WriteLine(scripture2.GetText());
            //Console.Clear();
        }
        while(userValue.ToLower() != "quit");
    }
}    
