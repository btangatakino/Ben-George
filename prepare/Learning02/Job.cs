using System;

public class Job
{
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public string _company;

    public void DisplayJobDetailsgit()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}