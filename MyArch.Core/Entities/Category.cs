namespace MyArch.Core.Entities
{
    public class Category : Entity<int>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();

        public Category()
        {

        }
        public Category(string name)
        {
            Name = name;

        }
    }
}
