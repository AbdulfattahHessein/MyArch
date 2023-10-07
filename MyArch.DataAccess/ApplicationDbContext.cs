using Microsoft.EntityFrameworkCore;
using MyArch.Core.Entities;

namespace MyArch.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(product =>
            {
                product.HasKey(p => p.Id);
                product.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
            });

            modelBuilder.Entity<Category>(product =>
            {
                product.HasKey(c => c.Id);
            });
        }
    }
}
