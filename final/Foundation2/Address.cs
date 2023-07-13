using System;
using System.Collections.Generic;

public class Address
{
    private string _city;
    private string _state;
    private string _street;
    private string _country;
    private bool _inUSA;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUSA
    {
        get {return _inUSA;}
        set { _inUSA = value;}
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Address:\nStreet: {_street}\nCity: {_city}\nState: {_state}\nCountry: {_country}");
    }

}