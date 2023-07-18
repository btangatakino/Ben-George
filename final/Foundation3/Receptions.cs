using System;
using System.Collections.Generic;

public class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string eventTitle, string description, string date, string time, string address, string rsvpEmail) : base(eventTitle, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }
    public void SetRsvpEmail(string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }
}