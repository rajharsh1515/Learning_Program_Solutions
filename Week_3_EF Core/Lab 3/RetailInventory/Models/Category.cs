namespace RetailInventory.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }

        public List<Product> Products { get; set; } = new();
    }
}
