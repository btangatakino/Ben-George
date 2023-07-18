using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //create 2 orders with 3 products each. Call the methods to display the packing label, the shipping label, and the total price of the order.
        Address address = new Address("14 Queen Street", "Mangere", "Auckland", "New Zealand");
        //Address address2 = new Address("14 Holy Street", "Arburn", "California", "USA");

        Order order = new Order();
        order.PackingLabel();
        order.ShippingLabel();
        
        Console.WriteLine(order.TotalPrice());
        
        Customer customer = new Customer();
        Console.WriteLine(customer.GetAddress());
    }
}