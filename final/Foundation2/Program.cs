 //Encapsulation with Online Ordering program from the Foundation 4 option.creating classes for products, customers, addresses, and orders. The classes are capable of capturing relevant information and performing necessary calculations.
  
using System;   
    
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("online ordering store!");
        Console.WriteLine("\n-------------------");

        Address address1 = new Address("123 Oak Street", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("Emily Wilson", address1);

        Product product1 = new Product("TV", 75641, 499.99, 1);
        Product product2 = new Product("Smartphone", 34562, 699.99, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Address address2 = new Address("45 High Street", "London", "WC1V 6EA", "United Kingdom");
        Customer customer2 = new Customer("Daniel Wilson", address2);

        Product product3 = new Product("Printer", 97541, 149.99, 1);
        Product product4 = new Product("Laptop", 87652, 899.99, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4); 

        Console.WriteLine("\n-------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}