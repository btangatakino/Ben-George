using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public int _numOfComments;
    public List<Comment> _comment = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public int NumOfComments()
    {
        _numOfComments = _comment.Count();
        return _numOfComments;
    }

    public void Display()
    {
        Console.WriteLine($"{_title} {_author} {_lengthInSeconds} {_numOfComments}");
    }
}