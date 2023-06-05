using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RandomScripture
{
    string _reference;
    string _verse;
    string _book;
    string _endVerse;
    string _chapter;

    public RandomScripture(string reference, string verse)
    {
        _reference = new Reference(book, chapter, verse);
        _verse = text;
        string[] words = text.Split(" ");
        foreach(string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
    }
    public void GenerateScripture()
    {
        Dictionary<string, string> scriptDict = new Dictionary<string, string>()
        {
            { "Moses 1:39", "For behold this is my work and my glory-to bring to pass the immortality and eternal-life of man." },
            { "James 3:5-6", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed." },
            { "Proverbs 3:5-6", "Trust in the Lord with all your heart; and lean not unto thine own understanding. In all thy ways, aknowledge him, and he shall direct thy paths." }
        };
        foreach (KeyValuePair<string, string> user in scriptDict)
        {
            Console.WriteLine(user.Key);
            Console.WriteLine(user.Value);

            
    }
        
        Random random = new Random();
        int myIndex = random.Next(user.Value.Length);
        displayScripture = scriptDict[myIndex];
        Console.WriteLine(_displayScripture);
        }
    }
    /*public string _displayScripture;
    private string _referenc;
    private string _ver;
    public RandomScripture()
    {
        _referenc = referenc;
        _ver = ver;
    }

    public void RandomScript()
    {
        var scriptsList = new List<KeyValuePair>(string, string);
        

        scriptsList.Add(new KeyValuePair<string, string>("Moses: 1:39", "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man"));
        
        scriptsList.Add(new KeyValuePair<string, string>("James 1:5", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."));
        
        scriptsList.Add(new KeyValuePair<string, string>("Proverbs 3:5-6", "Trust in the Lord with all your heart, and lean not to your own understanding. In all thy ways, acknowledge Him, and He shall direct thy paths."));

        Random random = new Random();
        int myIndex = random.Next(scriptsList.Count);
        _displayScripture = scriptsList[myIndex];
        Console.WriteLine(_displayScripture);
    }*/
}