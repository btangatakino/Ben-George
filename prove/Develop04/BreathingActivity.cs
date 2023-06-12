using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing";
        _description = "\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
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
}