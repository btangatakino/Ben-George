using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>()
        {
            new Product("Toaster", "TA0001", 42.00, 40),
            new Product("Bicycle", "BE0005", 259.99, 20),
            new Product("Smart Samsung Tv", "TE0001", 380, 10)
        };
    private  Customer _customer;

    public Order(){}

    public Order(Customer customer)
    {
        _customer = customer;
    }

    /*public double ShippingPrice()
    {
        double _shippingCost = 
        return _shippingCost;
    }*/

    public double TotalPrice()
    {
        double total = 0.0;
        foreach (Product product in _products)
        {
            total += product.ComputeTotal();
        }
        return total;
    }    

    public void PackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine($"");
        }
    }
    public void ShippingLabel()
    {
        Console.WriteLine("This is the shipping label");
    }
}