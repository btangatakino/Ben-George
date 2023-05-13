using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Entry
{
    public string _dateOfEntry;

    public string _entryPrompt;

    public string _entryResponse;

    public void Display()
    {
        Console.WriteLine($"{_dateOfEntry} {_entryPrompt} {_entryResponse}");
    }
}