using System;
using System.Collections.Generic;

public class Square : Shape
{
    private double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}


