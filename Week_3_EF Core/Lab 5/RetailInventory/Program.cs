using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

namespace RetailInventory
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using var context = new AppDbContext();
// Seed sample data if database is empty
if (!context.Products.Any())
{
    var electronics = new Category { Name = "Electronics" };
    var clothing = new Category { Name = "Clothing" };

    context.Categories.AddRange(electronics, clothing);

    context.Products.AddRange(
        new Product { Name = "Laptop", Price = 70000, Category = electronics },
        new Product { Name = "T-Shirt", Price = 1200, Category = clothing },
        new Product { Name = "Iphone", Price = 50000, Category = electronics }
    );

    await context.SaveChangesAsync();
}

            // Step 1: Retrieve All Products
            Console.WriteLine("All Products:");
            var products = await context.Products.ToListAsync();
            foreach (var p in products)
                Console.WriteLine($"{p.Name} - ₹{p.Price}");

            // Step 2: Find by ID
            var product = await context.Products.FindAsync(1);
            Console.WriteLine($"Found: {product?.Name ?? "Not found"}");

            // Step 3: FirstOrDefault with Condition
            var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
            Console.WriteLine($"Expensive: {expensive?.Name ?? "None found"}");
        }
    }
}
