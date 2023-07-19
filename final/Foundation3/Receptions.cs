using System;
using System.Collections.Generic;

public class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string eventTitle, string description, string date, string time, string address, string eventType, string eventInfor, string rsvpEmail) : base(eventTitle, description, date, time, address, eventType, eventInfor)
    {
        _rsvpEmail = rsvpEmail;
    }
    
    public void DisplayInfor()
    {
        Console.WriteLine($"RSVP Email:\t{_rsvpEmail}");
    }
}