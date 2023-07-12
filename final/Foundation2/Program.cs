using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Order order1 = new Order();
        order1.PackingLabel();
        order1.ShippingLabel();
        order1.TotalPrice();
    }
}