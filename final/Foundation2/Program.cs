using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //create 2 orders with 3 products each. Call the methods to display the packing label, the shipping label, and the total price of the order.
        Address address1 = new Address("14 Queen Street", "Mangere", "Auckland", "New Zealand");
        Address address2 = new Address("14 Holy Street", "Arburn", "California", "USA");

        Order order = new Order();
        order.PackingLabel();
        order.ShippingLabel();        
        
        Customer customer = new Customer();
        customer.SetCustomerName("John Jones");
        Console.WriteLine(customer.GetCustomerName());
        address1.ShippingAddress();
        //address2.ShippingAddress();

        Console.WriteLine("\nTotal Price: $" + order.TotalPrice());
    }
}