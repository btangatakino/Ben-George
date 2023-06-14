using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private string _dateTimeEntry;
    private string _response;
    private GeneratePrompt genP = new GeneratePrompt();
    private string _entry;
    public ListingActivity(string response, string entry)
    {
        _response = response;
        _entry = entry.Replace(",", "|");
        _dateTimeEntry = DateTime.Now.ToString("MM/dd/yyyy");
    }
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
            Console.Write("> ");
            string z = Console.ReadLine();
            /*
            string userFile = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{this._dateTimeEntry}, {this._response};
                    _response = _response.Replace(",", "|");
                }
            }*/            
        }
        Spinner(5);
        DisplayEndMessage();
    }

}