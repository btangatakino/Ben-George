using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Toaster", "TA0001", 42.00, 10);
        Product product2 = new Product("Bicycle", "BE0005", 259.99, 5);
        
        Address address1 = new Address("14 Queen Street", "Mangere", "Auckland", "New Zealand");
        Address address2 = new Address("14 Holy Street", "Arburn", "California", "USA");

        Order order1 = new Order();
        order1.PackingLabel();
        order1.ShippingLabel();
        order1.TotalPrice();
        //order1.DisplayAdress();

        Order order2 = new Order();
        order2.PackingLabel();
        order2.ShippingLabel();
        order2.TotalPrice();
    }
}