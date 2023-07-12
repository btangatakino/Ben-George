using System;
using System.Collections.Generic;

public class Order
{
    private double _price;
    private double _totalPrice;
    private double _shippingCost;
    public List<Product> _products = new List<Product>();
    public List<Customer> _customers = new List<Customer>();

    public double TotalPrice()
    {
        _totalPrice = _price + _shippingCost;
        return _totalPrice;
    }

    public void PackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine($"This is the product label");
        }
    }
    public void ShippingLabel()
    {
        foreach(Customer customer in _customers)
        {
            Console.WriteLine($"This is the customer label");
        }
    }
}