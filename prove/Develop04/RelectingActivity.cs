using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private GeneratePrompt gen = new GeneratePrompt();
                    
    public ReflectingActivity()
    {
        _activityName = "Reflecting";
        _description = "\nThis activity will help you on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you use it in other aspects of your life.";
    }
    public void RunActivity()
    {
        DisplayStartMessage();
        Console.WriteLine("Consider the following prompt:\n");
        //Console.WriteLine("\n--- Think of a time when you did somethig really difficult. ---");
        gen.GenerateReflectPrompt();
        /*Console.WriteLine("If you want a different prompt, type 1 or enter to continue with this prompt?");
        string y = Console.ReadLine();
        do
        {
            gen.GeneratePrompt();
            break;
        }while (y == "1");*/
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string x = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Timer(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            gen.GenerateReflectQuestion();
            Spinner(7);
        }
        DisplayEndMessage();
    }
}