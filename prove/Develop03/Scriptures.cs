using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
public class Scriptures
{   
    Reference _reference;
    private string _verse;
    private Random rnd = new Random();
    private List<Word> _words = new List<Word>();
    public Reference Reference{
        get{return _reference;}
    }

    public Scriptures(string book, int chapter, int verse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, verse, endVerse);
        _verse = text;
        string[] words = text.Split(" ");
        foreach(string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }

    }
    public Scriptures(string book, int chapter, int verse, string text)
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
    public void GetVerse()
    {
        Console.WriteLine($"{_verse}");
    }

    public void Display()
    {
        foreach(Word word in _words)
        {
            word.Display();
            Console.Write(" ");
        }
    }

    public bool AllWordsHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }

    public bool HideWord()
    {
        //set word is hidden
        int myRandomIndex = 0;
        myRandomIndex = rnd.Next(_words.Count);
        if(!_words[myRandomIndex].IsHidden)
        {
            _words[myRandomIndex].IsHidden = true; 
            return true;
        }
        return false;
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
}*/