using System;
using System.Collections.Generic;

public class Goals
{
    private int _pointsEarned = 0;
    private int _pointsWhenCompleted = 0;
    private string _goalName = "";
    private string _description = "";
    private bool _isCompleted = false;

    public Goals()
    {
        Console.WriteLine($"What is the name of your Goal? ");
        _goalName = Console.ReadLine();

        Console.WriteLine($"What is a short description of your Goal? ");
        _description = Console.ReadLine();

        
    }

    public Goals(string goalName, string description, int points)
    {
        _goalName = goalName;
        _description = description;
        _pointsEarned = points;
    }

    public bool IsComplete()
    {
        //_isCompleted = false;
        return _isCompleted;
    }

    /*public abstract DisplayGoal()
    {
        Console.WriteLine("Check if Goal is complete.");
    }*/
    
}