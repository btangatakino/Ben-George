using System;
using System.Collections.Generic;

public class Lectures : Event
{
    private string _lecturer;
    private int _capacity;

    public Lectures(){}

    public Lectures(string eventTitle, string description, string date, string time, string address, string lecturer, int capacity, string eventType, string eventInfor) : base(eventTitle, description, date, time, address, eventInfor, eventType)
    {
        _lecturer = lecturer;
        _capacity = capacity;
    }

    public string GetLecturer()
    {
        return _lecturer;
    }
    public void SetLecturer(string lecturer)
    {
        _lecturer = lecturer;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public void SetInfor(string lecture, int capacity)
    {
        _lecturer = lecture;
        _capacity = capacity;
    }
    public void DisplayInfor()
    {
        Console.WriteLine($"Lecturer:\t{_lecturer}\nInformation:\tCapacity of {_capacity}");
    }
}
