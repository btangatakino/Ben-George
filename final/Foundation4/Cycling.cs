using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double duration, string activityType, double speed) : base(date, duration, activityType)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return (_speed * _duration) / 60; 
    }

    public override double Speed()
    {
        return (Distance() / _duration)*60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }
}