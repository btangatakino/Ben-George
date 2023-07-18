using System;
using System.Collections.Generic;

public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    private string _eventType;
    private string _eventInfor;

    public Event(){}

    public Event(string eventTitle, string description, string date, string time, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public Event(string eventTitle, string description, string date, string time, string address, string eventType, string eventInfor)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
        _eventInfor = eventInfor;
    }

    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public void SetEventTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetTime()
    {
        return _time;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress(string address)
    {
        _address = address;
    }
    public string GetEventType()
    {
        return _eventType;
    }
    public void SetEventType(string eventType)
    {
        _eventType = eventType;
    }
    public string GetEventInfo()
    {
        return _eventInfor;
    }
    public void SetEventInfo(string eventInfor)
    {
        _eventInfor = eventInfor;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"Event Title:\t{_eventTitle}\nDescription:\t{_description}\nDate:\t\t{_date}\nTime:\t\t{_time}\nAddress:\t{_address}");
    }

    public void FullDetails()
    {
        Console.WriteLine($"Event Title:\t{_eventTitle}\nDescription:\t{_description}\nDate:\t\t{_date}\nTime:\t\t{_time}\nAddress:\t{_address}\nEvent Type:\t{_eventType}\nEventInfor:\t{_eventInfor}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Event Type:\t{_eventType}\nEvent Title:\t{_eventTitle}\nDate:\t\t{_date}");
    }
}