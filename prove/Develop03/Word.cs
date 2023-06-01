using System;
using System.Collections.Generic;
public class Word
{
    private string _word;
    private bool _isHidden;

    public bool IsHidden
    {
        get {return _isHidden;}
        set { _isHidden = value;}
    }
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    string word = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct they paths.";
    //track if single word is shown or hidden

    public Word(){}

    public void HideWords()
    {
        //set word is hidden
        string text = word;
        char[] separator = {',', ' '};
        string[] hideWords = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        int myRandomIndex = 0;
        var results = new List<string>();
        var r = new Random(DateTime.Now.Millisecond);

        myRandomIndex = r.Next(hideWords.Length);
        results.Add(hideWords[myRandomIndex]);
        //Console.WriteLine(hideWords[myRandomIndex]); //this gets a random word from the scripture
        //Console.WriteLine(string.Join("", results));
        Console.ReadKey();
        //Console.WriteLine(text);
        foreach (string w in hideWords)
        {
            text = text.Replace(w, new string('_', hideWords.Length));
            Console.Write(w + " ");
        }
    }
}/*

    private List<Word> GetVisibleWords()
    {
        throw new NotImplementedException();
    }

    public void ShowWords()
    {
        //logic if hidden then show __  if not hidden, then show the word
    }
    
    public void GetWords()
    {
        Console.WriteLine($"{_word}");
    }
}*/