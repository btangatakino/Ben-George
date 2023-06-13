using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private string _reflecting;

    public ReflectingActivity()
    {
        _activityName = "Reflecting";
        _description = "\nThis activity will help you on times in your life when you have shown. This will help you recognize the power you have and how you use it in other aspects of your life.";
    }
    public void RunActivity()
    {
        DisplayStartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            Timer(4);
            Console.Write("\nNow breathe out...");
            Timer(6);
            Console.WriteLine();
        }
        DisplayEndMessage();
    }

    public void RunReflect()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("\n--- Think of a time when you did somethig really dificult. ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Spinner();
    }
    
}