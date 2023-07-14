using System;
using System.Collections.Generic;

public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected DateTime _date;
    protected string _time;
    protected string _address;

    public void StandardDetails()
    {
        Console.WriteLine($"{_eventTitle} {_description} {_date} {_time} {_address}");
    }

    public void FullDetails()
    {
        Console.WriteLine();
    }

    public void ShortDescription()
    {
        Console.WriteLine();
    }
}