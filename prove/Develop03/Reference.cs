using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    //private int _endVerse;

    Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    /*Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
       _endVerse = endVerse;
    }*/

    public string GetReference()
    {
        _book = "Moses";
        _chapter = 1;
        _verse = 39;
        //_endVerse = 6;

        return ($"{_book} {_chapter}:{_verse}");
    }
}