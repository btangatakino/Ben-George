using System;
using System.Collections.Generic;

public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string eventTitle, string description, string date, string time, string address, string weather) : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }

}