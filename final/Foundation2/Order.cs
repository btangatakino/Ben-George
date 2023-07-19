using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>()
        {
            new Product("Toaster", "TA0001", 42.00, 40),
            new Product("Bicycle", "BE0005", 259.99, 20),
            new Product("Smart Tv", "TV0004", 380, 10)
        };
    /*private List<Product> _products2 = new List<Product>()
    {
        new Product("Freezer", "FR0101", 650.00, 5),
        new Product("Iron Board", "IBE025", 40.99, 20),
        new Product("Kettle", "KE1204", 35.50, 30)
    };*/
    protected string _customer;

    public Order(){}

    public Order(string customer)
    {
        _customer = customer;
    }

    /*public double ShippingPrice()
    {
        ifdouble _shippingCost = 
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
        Console.Clear();
        Console.WriteLine("Packing Label:");
        foreach(Product product in _products)
        {
           Console.WriteLine(product.GetProductName() + " " + product.GetProductID());
        }
    }
    public void ShippingLabel()
    {
        Console.WriteLine("\nShipping Label:");
        
    }
}