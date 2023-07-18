using System;
using System.Collections.Generic;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(){}

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void InUSA()
    {
        InUSA();
    }
}