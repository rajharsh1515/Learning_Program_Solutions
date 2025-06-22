using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_Platform_Search
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int productId, string productName, string category)
        {
            ProductId = productId;
            ProductName = productName;
            Category = category;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Phone", "Electronics"),
                new Product(3, "Shoes", "Fashion"),
                new Product(4, "Book", "Education"),
                new Product(5, "Tablet", "Electronics")
            };

            Console.Write("Enter product name to search: ");
            string searchQuery = Console.ReadLine();

            Console.WriteLine("\n--- Linear Search result ---");
            var result1 = LinearSearch(products, searchQuery);
            PrintResult(result1);

            Array.Sort(products, (a, b) => string.Compare(a.ProductName, b.ProductName, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\n--- Binary Search result ---");
            var result2 = BinarySearch(products, searchQuery);
            PrintResult(result2);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static Product LinearSearch(Product[] products, string targetName)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        static Product BinarySearch(Product[] products, string targetName)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = string.Compare(products[mid].ProductName, targetName, true);

                if (comparison == 0)
                    return products[mid];
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }

        static void PrintResult(Product product)
        {
            if (product != null)
            {
                Console.WriteLine($"Product Found: {product.ProductName} (ID: {product.ProductId}, Category: {product.Category})");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}