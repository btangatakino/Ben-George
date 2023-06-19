using System;
using System.Collections.Generic;

public class SimpleGoals : Goals
{
    public SimpleGoals() : base()
    {}
    private SimpleGoals(string goalName, string goalType, string description, int points) : base(goalName, goalType, description, points)
    {

    }
}