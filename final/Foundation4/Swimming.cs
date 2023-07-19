using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int _numOfLaps;

    public Swimming(string date, double duration, string activityType, int numOfLaps) : base(date, duration, activityType)
    {
        _numOfLaps = numOfLaps;
    }

    public override double Distance()
    {
        return (_numOfLaps * 50) / 1000;
    }

    public override double Speed()
    {
        return (Distance() / _duration) * 60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }
}