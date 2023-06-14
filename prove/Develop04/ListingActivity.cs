using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you on times in your life when you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }  

    public void RunActivity()
    {
        DisplayStartMessage();
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        /*Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("\nThis activity will help you on times in your life when you relect on the good things in your life by having you list as many things as you can in a certain area.");*/
        DisplayStartMessage();
        Spinner(5);
    }

}