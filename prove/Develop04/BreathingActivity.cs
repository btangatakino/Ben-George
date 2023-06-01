using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    private string _breathing;    

    public void DisplayBreathe()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("\nThis activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        Console.ReadLine();
    }
}