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
    
    public void Display()
    {
        foreach (Word word in _words)
        {
            word.Display();
            Console.Write(" ");
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }

    public bool HideWord()
    {
        //set word as hidden
        int myRandomIndex = 0;
        myRandomIndex = rnd.Next(_words.Count);
        if(!_words[myRandomIndex].IsHidden)
        {
            _words[myRandomIndex].IsHidden = true; 
            return true;
        }
        return false;
    }
    
    public void GetVerse()
    {
        Console.WriteLine($"{_verse}");
    }
}