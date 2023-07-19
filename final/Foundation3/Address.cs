using System;
using System.Collections.Generic;

public class Address
{
    private string _city;
    private string _state;
    private string _country;
    
    public Address(string city, string state, string country)
    {
        _city = city;
        _state = state;
        _country = country;
    }

    public Address(){}

    public string DisplayAddress(string city, string state, string country)
    {
        return($"{_city}, {_state}, {_country}");
    }
}