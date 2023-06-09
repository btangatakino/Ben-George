using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private string _reflecting;    

    public void DisplayReflect()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine("\nThis activity will help you on times in your life when you have shown. This will help you recognize the power you have and how you use it in other aspects of your life");
        DisplayStartMessage();
        Spinner();
    }

    public void RunReflect()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("\n--- Think of a time when you did somethig really dificult. ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\nYou may begin in:  ");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}