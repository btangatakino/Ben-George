using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Toaster", "TA0001", 42.00, 40);
        Product product2 = new Product("Bicycle", "BE0005", 259.99, 20);
        Product product3 = new Product("Smart Samsung Tv", "TE0001", 380, 10);
        
        Address address1 = new Address("14 Queen Street", "Mangere", "Auckland", "New Zealand");
        Address address2 = new Address("14 Holy Street", "Arburn", "California", "USA");
        Address address3 = new Address("24 Hazelwood Street", "Wynn", "Las Vegas", "USA");

        Order order1 = new Order();
        order1.PackingLabel();
        order1.ShippingLabel();
        order1.TotalPrice();
        
        Customer customer1 = new Customer();
        customer1.GetAddress();

        Order order2 = new Order();
        order2.PackingLabel();
        order2.ShippingLabel();
        order2.TotalPrice();
    }
}