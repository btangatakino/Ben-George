using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
       _endVerse = endVerse;
    }

    public void GetReference()
    {
        /*_book = "Proverbs";
        _chapter = 3;
        _verse = 5;
        _endVerse = 6;*/

        if (_endVerse == -1)
        {
            Console.WriteLine($"{_book} {_chapter}:{_verse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_verse}-{_endVerse}");
        }
    }
}