using System;
using System.Collections.Generic;

public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public double Price()
    {
        _price = _price*_quantity;
        return _price;
    }
}