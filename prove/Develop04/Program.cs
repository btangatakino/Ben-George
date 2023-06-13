using System;

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
                    ListingActivity l = new ListingActivity();
                    l.DisplayListing();
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