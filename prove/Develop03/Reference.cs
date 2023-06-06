using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Reference
{
    private int _bookNumber; //new line added
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    
    public Reference(string book, int chapter, int verse)
    {
        _bookNumber = -1; //new line added
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }

    public Reference(int bookNumber,string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }
    public Reference(string book, int chapter, int verse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endverse;
    }

    public void GetReference()
    {
        if (_endVerse == -1 && _bookNumber == -1)
        {
            Console.WriteLine($"{_book} {_chapter}:{_verse}");
        }
        else if (_endVerse == -1 && _bookNumber == 1)
        {
            Console.WriteLine($"{_bookNumber} {_book} {_chapter}: {_verse}");
        }
        else if (_endVerse == 1 && _bookNumber == 1)
        {
            Console.WriteLine($"{_bookNumber} {_book} {_chapter}: {_verse}-{_endVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_verse}-{_endVerse}");
        }
    }
}