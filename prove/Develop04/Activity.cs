using System;
using System.Collections.Generic;

public class Activity
{
    protected int _duration;
    protected int _userInput;
    protected string _activityName;
    protected string _description;

    public Activity()
    {}
    public Activity(int userInput, string activityName, string description, int duration)
    {
        _userInput = userInput;
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }/*
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string Display()
    {
        return ($"Welcome to the {_activityName} Activity\n\nThis Activity will help you throudh breathing in and out slowly. Clear your mind and focus on your breathing.\n\nHow long, in seconds, would you like for your session?");
    }*/
    public void DisplayStartMessage()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.Clear();
        Console.WriteLine("Get Ready");
    }
    
    public void Spinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
    }
}