using System;

public class Entry
{
    public string _listOfEntries;

    public string _dateOfEntry = "29th April 1970";

    public string _promptResponse = "I was born on that day.";

    public string _promptQuestion = "What interesting event happened to you on that day?" ;
    
    public void Display()
    {
        Console.WriteLine($"{_dateOfEntry} {_promptQuestion} {_promptResponse}");
    }
}