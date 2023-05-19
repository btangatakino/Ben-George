using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
public class Entry
{
    public string _dateTimeEntry;

    public string _entryPrompt;

    public string _entryResponse;

    public Entry(string entryPrompt, string entryResponse)
    {
        // Gets the prompt and stores it in a Variable (As a String)
        _entryPrompt = entryPrompt;
        // Gets the user Entry and stores in in a Variale (As a String)
        _entryResponse = entryResponse.Replace(",", "|");
        // Gets the date and stores it in a Variable
        _dateTimeEntry = DateTime.Now.ToString("MM/dd/yyyy");
    }
    public void DisplayUserEntry()
    {
        Console.WriteLine($"{_dateTimeEntry} {_entryPrompt} {_entryResponse}");
    }

    public string GetSaveFormat()
    {
        return $"{this._dateTimeEntry}, {this._entryPrompt}, {this._entryResponse}";
    }
}