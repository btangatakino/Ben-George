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
    string word = "Trust in the Lord with all thine heart, and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct they path";
    //track if single word is shown or hidden

    public Word(){}

    public void HideWords()
    {
        //set word is hidden
        string text = word;
        string[] hideWords = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        
        //Console.WriteLine(text);
        foreach (string w in hideWords)
        {
            //text = text.Replace(word, new string('_', word.Length));
            Console.Write(w + " ");
        }
            /*do
        {
            Random random = new Random();
        int myIndex = random.Next(text.Count);
        text = splitText[myIndex];
        Console.WriteLine(_scripts);
        }while()
        }*/
        //Console.WriteLine(text);
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
    }*/
}

