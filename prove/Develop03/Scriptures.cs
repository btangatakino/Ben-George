using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Scriptures
{
    private List<Word> _script = new List<Word>();
    //private string _reference;
    private string _text;

    public Scriptures()
    {
        _text = "For behold, this is my work and my glory, to bring to pass the immortality and eternal life of man.";
    }

    public Scriptures(string text)
    {
        _text = text.Replace(",", "|");
        text = "For behold, this is my work and my glory, to bring to pass the immortality and eternal life of man.";
        string[] words = text.Split(' ');
        foreach (String word in words)
        {
            Word w = new Word(word);
            _script.Add(w);
            Console.WriteLine(word);
        }
    }
    /*public string GetVerse()
    {
        return ($"{_script}");
    }*/
    public string GetText()
    {
        return ($"{_text}");
    }
}

    /*public Scriptures()
    {
            
            list.Add(new KeyValuePair<string, string>("Moses: 1:39", "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man"));
            list.Add(new KeyValuePair<string, string>("James 1:5", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."));
            list.Add(new KeyValuePair<string, string>("Proverbs 3:5-6", "Trust in the Lord with all your heart, and lean not to your own understanding. In all thy ways, acknowledge Him, and He shall direct thy paths."));

        Random random = new Random();
        int myIndex = random.Next(list.Count);
        _scriptList = list[myIndex];
        Console.WriteLine(_scriptList);
    }
    
    //method to hide words
    public void HideWords()
    {

    }

    //method to display the text
    
}*/