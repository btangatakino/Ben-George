using System;
using System.Collections.Generic;

public class Address
{
    private string _city;
    private string _state;
    private string _street;
    private string _country;
    private bool _inUSA;

    public void _InUSA()
    {

    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Address: {_street}, {_city}, {_state}, {_country}");
    }

}