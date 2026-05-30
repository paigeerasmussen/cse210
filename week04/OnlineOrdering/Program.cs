using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates at least 2 orders with 2-3 products each. Calls methods to get packing label, shipping label, total price, and displays results.

        Address a1 = new Address("123 Street", "New York City", "New York", "USA");
        Customer c1 = new Customer("John Smith", a1);
        Product p11 = new Product("Lotion", "AA12345", 6.25m, 2);
        Product p12 = new Product("Shampoo", "AA12366", 9.95m, 1);
        Product p13 = new Product("Conditioner", "AA12388", 8.65m, 1);
        Order o1 = new Order(c1);

        o1.AddProduct(p11);
        o1.AddProduct(p12);
        o1.AddProduct(p13);

        Console.WriteLine($"Ship To:\n{o1.ShippingLabel()}\n");
        Console.WriteLine($"Items:\n{o1.PackagingLabel()}");
        Console.WriteLine($"Total Price: ${o1.TotalPrice():0.00}");
        Console.WriteLine();

        Address a2 = new Address("456 Street", "London", "SW1A", "United Kingdom");
        Customer c2 = new Customer("Maggy Johnson", a2);
        Product p21 = new Product("Toothbrush", "BB12345", 10.15m, 1);
        Product p22 = new Product("Toothpaste", "BB12366", 5.65m, 1);
        Product p23 = new Product("Mouthwash", "BB12388", 4.95m, 1);
        Order o2 = new Order(c2);

        o2.AddProduct(p21);
        o2.AddProduct(p22);
        o2.AddProduct(p23);

        Console.WriteLine($"Ship To:\n{o2.ShippingLabel()}\n");
        Console.WriteLine($"Items:\n{o2.PackagingLabel()}");
        Console.WriteLine($"Total Price: ${o2.TotalPrice():0.00}");
        Console.WriteLine();
    }
}