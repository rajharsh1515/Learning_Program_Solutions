using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            // database is created
            context.Database.EnsureCreated();

            // Seed sample data 
            if (!context.Categories.Any())
            {
                var electronics = new Category { Name = "Electronics" };
                var groceries = new Category { Name = "Groceries" };

                context.Categories.AddRange(electronics, groceries);

                context.Products.AddRange(
                    new Product { Name = "Laptop", Price = 1200m, Category = electronics },
                    new Product { Name = "Smartphone", Price = 800m, Category = electronics },
                    new Product { Name = "Apple", Price = 2m, Category = groceries },
                    new Product { Name = "Milk", Price = 1.5m, Category = groceries }
                );

                context.SaveChanges();
            }

            // Display data
            var categories = context.Categories
                                    .OrderBy(c => c.Name)
                                    .ToList();

            Console.WriteLine("Product Categories and Products:");
            foreach (var category in categories)
            {
                Console.WriteLine($"- {category.Name}");

                var products = context.Products
                                      .Where(p => p.CategoryId == category.Id)
                                      .ToList();

                foreach (var product in products)
                {
                    Console.WriteLine($"  - {product.Name} (${product.Price})");
                }
            }
        }
    }
}
