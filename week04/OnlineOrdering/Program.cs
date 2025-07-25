using System;

class Program
{
    static void Main(string[] args)
    {
        Customer cust1 = new Customer("John Doe", new Address("101 E Viking St", "Rexburg", "Idaho", "USA"));
        Customer cust2 = new Customer("Jane Smith", new Address("202 Maple St", "Toronto", "Ontario", "Canada"));

        Product prod1 = new Product("Toy", "W123", 10.0, 5);
        Product prod2 = new Product("Watch", "G456", 15.5, 2);
        Product prod3 = new Product("Gadget", "T789", 7.25, 3);

        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        Order order2 = new Order(cust2);
        order2.AddProduct(prod2);
        order2.AddProduct(prod3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Address: " + order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotal()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Address: " + order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotal()}");
    }
}