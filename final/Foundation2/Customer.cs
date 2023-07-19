using System;
using System.Collections.Generic;

public class Customer
{
    protected string _customerName;
    private Address _address;

    public Customer(){}

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
 
    public Address GetAddress()
    {
        return _address;
    }

    public bool InUSA()
    {
        return _address.InUSA();
    }
}