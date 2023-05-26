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

    //track if single word is shown or hidden

    public void HideWords()
    {
        //set word is hidden
        List<Word> visibleWords = GetVisibleWords();
        if (visibleWords.Count == 0)
            return;

        Random random = new Random();
        int randomIndex = random.Next(visibleWords.Count);
        visibleWords[randomIndex].Hide();
    }

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
}

