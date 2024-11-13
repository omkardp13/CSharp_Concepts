using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;

class Program
{

    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }

    public async Task FilterWithIQueryable()
    {
        using (var context = new ProductContext())
        {
            IQueryable<Product> expensiveProducts = context.Products.Where(p => p.Price > 500);

            // SQL query executed when enumerating or calling ToListAsync
            var result = await expensiveProducts.ToListAsync();

            foreach (var product in result)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }
        }
    }


    static void Main()
    {

        FilterWithIQueryable();


    }
}
