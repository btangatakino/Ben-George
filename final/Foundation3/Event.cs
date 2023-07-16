using System;
using System.Collections.Generic;

public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventType;
    protected string _eventInfor;

    public Event(string eventTitle, string description, string date, string time, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"{_eventTitle} {_description} {_date} {_time} {_address}");
    }

    public void FullDetails()
    {
        Console.WriteLine($"{_eventTitle}, {_description}, {_date}, {_time}, {_address}, {_eventType}, {_eventInfor}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"{_eventType}, {_eventTitle}, {_date}");
    }
}