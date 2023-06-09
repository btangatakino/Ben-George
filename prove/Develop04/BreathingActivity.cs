using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
    
    public void BreatheIn()
    {
        Console.Write("\nBreathe in...");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void BreatheOut()
    {
        Console.Write("\nNow breathe out...");
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");;
        }
        Console.WriteLine();
    }
    public void GetEndMessage()
    {
        Console.WriteLine("\nYou have completed another 30 seconds of the Breathing Activity");
        Spinner();
    }
}