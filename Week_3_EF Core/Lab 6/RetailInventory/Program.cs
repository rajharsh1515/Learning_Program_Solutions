using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;
using RetailInventory.Data;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            // Ensure category exists
            var category = await context.Categories.FirstOrDefaultAsync(c => c.Name == "Electronics");
            if (category == null)
            {
                category = new Category { Name = "Electronics" };
                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();
                Console.WriteLine(" Category 'Electronics' added.");
            }

            // Insert Laptop if missing
            if (!await context.Products.AnyAsync(p => p.Name == "Laptop"))
            {
                var laptop = new Product { Name = "Laptop", Price = 60000, CategoryId = category.Id };
                await context.Products.AddAsync(laptop);
            }

            // Insert Rice Bag if missing
            if (!await context.Products.AnyAsync(p => p.Name == "Rice Bag"))
            {
                var riceBag = new Product { Name = "Rice Bag", Price = 1500, CategoryId = category.Id };
                await context.Products.AddAsync(riceBag);
            }

            await context.SaveChangesAsync();
            Console.WriteLine(" Sample products inserted (if missing).");

            // Update Laptop price
            var laptopToUpdate = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
            if (laptopToUpdate != null)
            {
                Console.WriteLine($"Original Laptop Price: ₹{laptopToUpdate.Price}");
                laptopToUpdate.Price = 70000;
                await context.SaveChangesAsync();
                Console.WriteLine(" Laptop price updated to ₹70000");
            }
            else
            {
                Console.WriteLine(" Laptop not found.");
            }

            // Delete Rice Bag
            var riceBagToDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
            if (riceBagToDelete != null)
            {
                context.Products.Remove(riceBagToDelete);
                await context.SaveChangesAsync();
                Console.WriteLine(" Rice Bag deleted successfully.");
            }
            else
            {
                Console.WriteLine(" Rice Bag not found.");
            }
        }
    }
}
