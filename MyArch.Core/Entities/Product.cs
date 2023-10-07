namespace MyArch.Core.Entities
{
    public class Product : Entity<int>
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Product()
        {
            Category = new Category();
        }
        public Product(string name, decimal price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
