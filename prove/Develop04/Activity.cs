using System;
using System.Collections.Generic;

public class Activity
{
    protected int _duration;
    //protected int _userInput;
    protected string _activityName;
    protected string _description;

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready");
        Spinner(5);
    }
    
    public void Spinner(int duration)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        int x = 0;

        while (DateTime.Now < endTime)
        {
            x = i % animationStrings.Count;
            string s = animationStrings[x];
            Console.Write(s);
            Thread.Sleep(400);
            Console.Write("\b \b");
            i++;        
        }
    }

    protected void Timer(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!!");
        Spinner(5);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_activityName} Activity");
        Spinner(5);
    }
}