using System;
using System.Collections.Generic;

public class Program
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
        /*static string DisplayGoalMenu()
        {
            Console.WriteLine("The type of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. CheckListGoal");
            Console.WriteLine("Which type of goal would you like to create? ");
            string userInput2 = Console.ReadLine();
            return userInput2;
        }*/
        string userInput = "";
        //string userInput2 = "";

        while (userInput != "6")
        {
            userInput = DisplayMenu();
            switch (userInput)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    DisplayGoal();          
                    break;

                case "3":
                    SaveGoal();                    
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent();
                    break;
                
                case "6":
                    Console.WriteLine("Thank you!");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                    break;
            }
        }
    }
}