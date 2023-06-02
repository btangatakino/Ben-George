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
   
    public void Display()
    {
        if(_isHidden)
        {
            foreach(char letter in _word)
            {
                Console.Write("_");
            }
        }
        else
            Console.Write(_word);
    }  
}