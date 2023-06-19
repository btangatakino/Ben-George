using System;
using System.Collections.Generic;

public class Goals
{
    private int _points;
    private string _goalName;
    private string _goalType;
    private string _description;
    private bool _isComplete;

    public Goals()
    {}

    public Goals(string goalName, string goalType, string description, int points)
    {
        _goalName = goalName;
        _goalType = goalType;
        _description = description;
        _points = points;
    }

    public bool IsComplete()
    {
        _isComplete = false;
        return _isComplete;
    }
    
}