using System;
using System.Collections.Generic;

public class Order
{
    private double _price;
    private double _totalPrice;
    private double _shippingCost;
    public List<Product> _products = new List<Product>();
    public List<Customer> _customers = new List<Customer>();

    public void PackingLabel()
    {
        Console.WriteLine($"");
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"");
    }
}