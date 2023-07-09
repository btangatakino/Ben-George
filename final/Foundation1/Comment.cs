using System;
using System.Collections.Generic;

public class Comment
{
    public string _nameOfPerson;
    public string _comment;

    public void Display()
    {
        Console.WriteLine($"Commentor: {_nameOfPerson}, Comment: {_comment}");
    }
}