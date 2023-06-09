using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    private string _breathing;  

    public BreathingActivity() : base()
    {}  

    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {}
    public void DisplayBreathe()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        DisplayStartMessage();
        Spinner();
        //DisplayEndMessage();
        //GetReadySpinner();
    }
    public void BreathIn()
    {
        Console.WriteLine();
        Console.Write("Breath in...");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void BreathOut()
    {
        Console.Write("\nNow breath out...");
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void GetEndMessage()
    {
        Console.WriteLine("\nYou have completed another 30 seconds of the Breathing Activity");
        Spinner();
    }
}