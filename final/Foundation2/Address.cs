using System;
using System.Collections.Generic;

public class Address
{
    private string _city;
    private string _state;
    private string _street;
    private string _country;
  

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUSA()
    {
        if (_country == "Usa" || _country == "USA" || _country == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ShippingAddress()
    {
        Console.WriteLine($"Address:\nStreet: {_street}\nCity: {_city}\nState: {_state}\nCountry: {_country}");
    }

}