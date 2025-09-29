using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");


        // Create an address
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");
        // Create a customer
        Customer customer = new Customer("John Doe", address);
        // Create an order
        Order order = new Order(customer);
        // Add products to the order
        order.AddProduct(new Product("Laptop", "P001", 999.99, 1));
        order.AddProduct(new Product("Mouse", "P002", 25.50, 2));
        // Display packing label
        Console.WriteLine(order.GetPackingLabel());
        // Display shipping label
        Console.WriteLine(order.GetShippingLabel());
        // Display total cost
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");           
        
    }
}