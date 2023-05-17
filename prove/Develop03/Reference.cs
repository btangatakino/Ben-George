using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    public Reference()
    {
        _book = "Proverbs";
        _chapter = 3;
        _verse = 5-6;
    }

    //Display the reference as; book, chapter and verse
    public void DisplayReference()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}