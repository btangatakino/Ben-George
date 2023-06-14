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
        Console.WriteLine("\nConsider the following prompt:\n");
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
        /*ConsoleKeyInfo key1 = Console.ReadKey();
        if (key1 == 1)
        {
            gen.GenerateReflectPrompt();
            Console.WriteLine("\nWhen you have something in mind, press enter to continue, or if you want a different prompt, type 1.");
        }
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");*/
        BeginTimer();
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