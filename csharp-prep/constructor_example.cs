using System;
using System.Collections.Generic;

public class Cars
{
    public string _color;
    public string _drive;
    public string _brand;
    public void CarInfo()
    {
        Console.WriteLine($"{_color} {_drive} {_brand}");
    }
}