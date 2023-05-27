using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Scriptures
{
    private List<Word> _scripts;
    //private string _reference;
    private Reference _reference;

    //private string text;
    private string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
    
    public Scriptures(){}

    public Scriptures(string book, int chapter, int verse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, verse, endVerse);
        List<Word> scripts = new List<Word>();

        }
    public void Display()
    {
        Console.WriteLine($"{_reference}");
        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            //Console.Write(word);
            _scripts.Add(new Word(word));
            //Console.WriteLine(_scripts);
        }
    }
    public void GetText()
    {
        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {   //this part not working
            Console.Write(word);
            Console.WriteLine();
            _scripts.Add(new Word(word));
            Console.WriteLine($"{splitText}");
        }/*

        do
        {
            Random random = new Random();
        int myIndex = random.Next(_scripts.Count);
        _scripts = splitText[myIndex];
        Console.WriteLine(_scripts);
        }while()

        List<Word> visibleWords = GetVisibleWords();*/
    }
}
    /*internal bool GetText()
    {
        throw new NotImplementedException();
    }
}
    /*public void GetText()
    {
        //Console.WriteLine($"{String.Join(" ", _script)}");
        foreach (Word words in _words)
        {
            Console.WriteLine(words);
        }
        //Console.WriteLine($"{_script}");
    }
}
        
        
        /*_text = text;
        text = "For behold, this is my work and my glory, to bring to pass the immortality and eternal life of man.";
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word w = new Word(word);
            _script.Add(w);
            Console.WriteLine(word);
        }*/
    
    /*public string GetVerse()
    {
        return ($"{_script}");
    }*/
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