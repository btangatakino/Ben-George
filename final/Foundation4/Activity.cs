using System;
using System.Collections.Generic;

public abstract class Activity
{
    private string _date;
    protected double _duration;
    private string _activityType;

    public Activity(string date, double duration, string activityType)
    {
        _date = date;
        _duration = duration;
        _activityType = activityType;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public virtual void GetSummary()
    {
        Console.WriteLine(_date + " " + _activityType + "(" +_duration + ")-" + Distance() + " km, Speed: " + Speed() + " kph, Pace: " + Pace() + "min per km"); 
    }
}