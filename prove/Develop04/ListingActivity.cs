using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private GeneratePrompt genP = new GeneratePrompt();
    public ListingActivity()
    {
        _activityName = "Listing";
        _description = "\nThis activity will help you on times in your life when you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }  

    public void RunActivity()
    {
        DisplayStartMessage();
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        genP.GeneratePrompsList();
        BeginTimer();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
           
        Spinner(5); 
            
        }
        DisplayEndMessage();
    }

}