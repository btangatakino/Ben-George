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
    
    List<Scriptures> scripture = new List<Scriptures>();

    Scriptures script1 = new Scriptures(reference, text);
    Scriptures script2 = new Scriptures(reference, text);
    Scriptures script3 = new Scriptures(reference, text);

    List<string> scriptures = new List<string>();
        scriptures.Add("James 1:5 If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.");
        scriptures.Add("Proverbs 3:5-6 Trust in the Lord with all your heart, and lean not to your own understanding. In all thy ways, acknowledge Him, and He shall direct thy paths.");
        scriptures.Add("Moses 1:39 For behold, this is my work and my glory, to bring to pass the imortality and eternal life of man.");

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