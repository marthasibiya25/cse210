using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Customer cust2 = new Customer("Bob Smith", addr2);

        // Create products
        Product prod1 = new Product("Laptop", "L100", 1200.50, 1);
        Product prod2 = new Product("Mouse", "M200", 25.99, 2);
        Product prod3 = new Product("Keyboard", "K300", 45.00, 1);
        Product prod4 = new Product("Monitor", "MN400", 300.00, 1);

        // Create orders
        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        Order order2 = new Order(cust2);
        order2.AddProduct(prod3);
        order2.AddProduct(prod4);

        // List of orders
        List<Order> orders = new List<Order> { order1, order2 };

        // Display order details
        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}\n");
        }
    }
}
