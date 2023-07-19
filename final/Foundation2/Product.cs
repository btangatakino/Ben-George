using System;
using System.Collections.Generic;

public class Product
{
    protected string _productName;
    protected string _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    /*public Product(string productName, string productId)
    {
        _productName = productName;
        _productId = productId;
    }*/

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productId;
    }

    public double ComputeTotal()
    {
        _price = _price*_quantity;
        return _price;
    }
}