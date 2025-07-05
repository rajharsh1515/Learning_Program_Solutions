using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            // Insert test data if missing
            var category = await context.Categories.FirstOrDefaultAsync();
            if (category == null)
            {
                category = new Category { Name = "Default" };
                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();
            }

            if (!await context.Products.AnyAsync())
            {
                var products = new[]
                {
                    new Product { Name = "Laptop", Price = 70000, CategoryId = category.Id },
                    new Product { Name = "Smartphone", Price = 25000, CategoryId = category.Id },
                    new Product { Name = "Rice Bag", Price = 1500, CategoryId = category.Id },
                    new Product { Name = "Pen", Price = 10, CategoryId = category.Id }
                };
                await context.Products.AddRangeAsync(products);
                await context.SaveChangesAsync();
                Console.WriteLine(" Sample products inserted.");
            }

            // Step 1: Filter and Sort
            var filtered = await context.Products
                .Where(p => p.Price > 1000)
                .OrderByDescending(p => p.Price)
                .ToListAsync();

            Console.WriteLine("\n Filtered Products (Price > ₹1000, Sorted Descending):");
            foreach (var p in filtered)
            {
                Console.WriteLine($"🔹 {p.Name} - ₹{p.Price}");
            }

            // Step 2: Project into DTO (anonymous type)
            var productDTOs = await context.Products
                .Select(p => new { p.Name, p.Price })
                .ToListAsync();

            Console.WriteLine("\n Projected Product DTOs (Name & Price only):");
            foreach (var dto in productDTOs)
            {
                Console.WriteLine($" {dto.Name} - ₹{dto.Price}");
            }
        }
    }
}
