using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public int _numOfComments;
    public List<Comment> _comments = new List<Comment>();

    /*public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }*/

    public void Display()
    {
        Console.WriteLine($"\nTitle: {_title}, Author: {_author}, Duration(secs): {_lengthInSeconds}, Total Comments: {NumOfComments()}");
        foreach(Comment comment in _comments)
        {
            comment.Display();
        }
    }

    public int NumOfComments()
    {
        _numOfComments = _comments.Count();
        return _numOfComments;
    }

}