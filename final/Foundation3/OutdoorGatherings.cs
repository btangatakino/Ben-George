using System;
using System.Collections.Generic;

public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string eventTitle, string description, string date, string time, string address, string eventType, string eventInfor, string weather) : base(eventTitle, description, date, time, address, eventType, eventInfor)
    {
        _weather = weather;
    }
    public void DisplayInfor()
    {
        Console.WriteLine($"Weather:\t{_weather}");
    }

}