using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventory.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
     optionsBuilder.UseSqlServer("Server=BT-22051337\\SQLEXPRESS;Database=ProductsDB;Trusted_Connection=True;Encrypt=False;");


        }
    }
}
