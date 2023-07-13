using System;
using System.Collections.Generic;

public class Event
{
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private string _time;
    private string _address;

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