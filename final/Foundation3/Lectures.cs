using System;
using System.Collections.Generic;

public class Lectures : Event
{
    private string _lecturer;
    private int _capacity;

    public Lectures(string lecturer, int capacity) : base(eventTitle, description, date, time, address)
    {
        _lecturer = lecturer;
        _capacity = capacity;
    }
}
