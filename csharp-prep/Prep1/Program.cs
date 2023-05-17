using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you firts name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
    

    public List<Entry> _entry = new List<Entry>();

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
}
