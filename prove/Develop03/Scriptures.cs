using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Scriptures
{
    private string _reference;
    private string _text;

    Scriptures(string reference, string text)
    {
        _reference = reference;
        _text = text;
    
        var list = new List<KeyValuePair<string, string>>();
        list.Add(new KeyValuePair<string, string>("Moses: 1:39", "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man"));
        list.Add(new KeyValuePair<string, string>("James 1:5", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."));
        list.Add(new KeyValuePair<string, string>("Proverbs 3:5-6", "Trust in the Lord with all your heart, and lean not to your own understanding. In all thy ways, acknowledge Him, and He shall direct thy paths."));

foreach (var element in list)
{
    Console.WriteLine(element);
}

    }
    //method to hide words
    public void HideWords()
    {

    }

    //method to display the text
    public void DisplayText()
    {
        Console.WriteLine("You have called the DisplayText method of the Scripture class");
    }
}