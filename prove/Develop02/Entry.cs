/*using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class Entry
{
    public string _dateTimeEntry;

    public string _entryPrompt;

    public string _entryResponse;

    public string DateTimeEntry()
    {
        //set date and time
        DateTime timeOfEntry = DateTime.Now;
        string dateTime = timeOfEntry.ToShortDateString();
        return dateTime;
    }

    public void DisplayUserEntry()
    {
        Console.WriteLine($"{_dateTimeEntry} {_entryPrompt} {_entryResponse}");
    }
}