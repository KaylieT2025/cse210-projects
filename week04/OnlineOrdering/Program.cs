using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        //Address
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Address address2 = new Address("123 Milk Dr", "Toronto", "ON", "Canada");

        //Customers
        Customer customer1 = new Customer("Lucy Prim", address1);
        Customer customer2 = new Customer("Hank Whisk", address2);

        //Orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        //order1
        order1.AddProduct(new Product("Laptop", "P1XYZ", 900.00, 1));
        order1.AddProduct(new Product("Sticky Note Pack", "SN890", 5.00, 2));

        //order2
        order2.AddProduct(new Product("Notebook", "NB756", 10.00, 3));
        order2.AddProduct(new Product("Erasable Pens", "EP3645", 15.00, 1));

        //order1 information display.
        Console.WriteLine(order1.PackagingLable());
        Console.WriteLine();
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.DisplayText());
        Console.WriteLine();

        //order2 information display.
        Console.WriteLine(order2.PackagingLable());
        Console.WriteLine();
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.DisplayText());
    }
}