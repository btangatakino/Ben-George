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

    public void StandardDetails()
    {
        Console.WriteLine($"*****Standard Details*****\nEvent Title:\t{_eventTitle}\nDescription:\t{_description}\nDate:\t\t{_date}\nTime:\t\t{_time}\nAddress:\t{_address}");
    }

    public void FullDetails()
    {
        Console.WriteLine($"*****Full Details*****\nEvent Title:\t{_eventTitle}\nDescription:\t{_description}\nDate:\t\t{_date}\nTime:\t\t{_time}\nAddress:\t{_address}\nEvent Type:\t{_eventType}\nEventInfor:\t{_eventInfor}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"*****Short Description*****\nEvent Type:\t{_eventType}\nEvent Title:\t{_eventTitle}\nDate:\t\t{_date}\n");
    }
}