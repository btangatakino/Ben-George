using System;

/*
Here are the extra things that I did:
1. At the begining of the program, when the user is asked to select a choice from the menu and they enter anything other than the numbers 1 to 4, an 'Invalid input. Please enter a number from 1 to 4.' will be displayed.
2. In the Reflecting Activity, all the questions displayed to the user to reflect on are not repeated until all the questions in the List are used.
3. In the Reflecting Activity, the user is asked if they want a different prompt by typing 1. The user is then given another prompt
*/
class Program
{
    static void Main(string[] args)
    {
        static string DisplayMenu()
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        string userInput = "";

        while (userInput != "4")
        {
            userInput = DisplayMenu();
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathe = new BreathingActivity();
                    breathe.RunActivity();
                    break;

                case "2":
                    Console.Clear(); 
                    ReflectingActivity reflect = new ReflectingActivity();
                    reflect.RunActivity();                    
                    break;

                case "3":
                    Console.Clear();
                    ListingActivity list = new ListingActivity();
                    list.RunActivity();
                    break;

                case "4":
                    Console.WriteLine("Thank you!");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                    break;
            }
        }
    }
}