/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayEntryList()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayUserEntry();
        }
    }
 }