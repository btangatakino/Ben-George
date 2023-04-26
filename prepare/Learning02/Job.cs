using System;

public class Job
{
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public string _company;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}