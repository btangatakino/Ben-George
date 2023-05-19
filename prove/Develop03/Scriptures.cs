using System;

public class Scriptures
{
    private string _reference;
    private string _text;

    Scriptures(string reference, string text)
    {
        _reference = reference;
        _text = text;
    
    Scriptures script1 = new Scriptures(reference, text);
    Scriptures script2 = new Scriptures(reference, text);
    Scriptures script3 = new Scriptures(reference, text);
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