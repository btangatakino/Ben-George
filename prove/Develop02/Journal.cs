using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayEntry()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayUserEntry();
        }
    }
    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saviing to file...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetSaveFormat());
            }
        }
    }
    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string savedEntry = parts[2];
            // Pulls the prompt used to prompt the entry and store it in a variable
            Entry entry = new Entry(parts[1], savedEntry.Replace("|", ","));
            // pulls the date from the entry, and stores it in a variable
            entry._dateTimeEntry = parts[0];
            // adds the entries to the list. 
            _entries.Add(entry);
        }

    }
}