using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public static void FilterWithIEnumerable()
    {
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200 },
             new Product { Id = 2, Name = "Tablet", Price = 300 },
            new Product { Id = 3, Name = "Phone", Price = 700 }
        };

        IEnumerable<Product> expensiveProducts = products.Where(p => p.Price > 500);

        foreach (var product in expensiveProducts)
        {
            Console.WriteLine($"{product.Name} - ${product.Price}");
        }
    }
    static void Main()
    {
        FilterWithIEnumerable();
        Console.Read();
    }

    
}
