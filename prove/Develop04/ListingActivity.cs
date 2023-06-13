using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private string _listing;    

    public void DisplayListing()
    {
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("\nThis activity will help you on times in your life when you relect on the good things in your life by having you list as many things as you can in a certain area.");
        DisplayStartMessage();
        Spinner(5);
    }

}