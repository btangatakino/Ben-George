using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.PackingLabel();
        order1.ShippingLabel();
        order1.TotalPrice();

        Order order2 = new Order();
        order2.PackingLabel();
        order2.ShippingLabel();
        order2.TotalPrice();
    }
}