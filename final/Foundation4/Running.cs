using System;
using System.Collections.Generic;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double duration, string activityType, double distance) : base(date, duration, activityType)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return (_distance / _duration)*60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }
}