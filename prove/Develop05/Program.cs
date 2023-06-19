using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You have 0 points.");

        static string DisplayMenu()
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        static string DisplayGoalMenu()
        {
            Console.WriteLine("The type of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. CheckListGoal");
            Console.WriteLine("Which type of goal would you like to create? ");
            string userInput2 = Console.ReadLine();
            return userInput2;
        }
        string userInput = "";

        while (userInput != "6")
        {
            userInput = DisplayMenu();
            switch (userInput)
            {
                case "1":
                    userInput = DisplayGoalMenu();
                    

                    /*if  (userInput`
                    )= Console.ReadLine();*/
                    break;

                case "2":
                    Console.Clear(); 
                    //create new goal
                    Console.WriteLine("What type of goal would you want to create? ");               
                    break;

                case "3":
                    
                    break;

                case "4":
                    
                    
                    break;

                case "5":
                    
                    break;
                
                case "6":
                    
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                    break;
            }
        }
    }
}