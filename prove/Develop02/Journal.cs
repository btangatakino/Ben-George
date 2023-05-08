using System;

public class Journal
{
    public void displayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        
    }

    public int promptUserInput()
    {
        Console.WriteLine("What would you like to do?");
        int userInput = int.Parse(Console.ReadLine());
        Console.ReadLine();
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
    }
}