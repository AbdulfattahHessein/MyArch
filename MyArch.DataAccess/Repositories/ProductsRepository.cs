using Microsoft.EntityFrameworkCore;
using MyArch.Core.Entities;
using MyArch.Core.Interfaces.Repositories;
using MyArch.DataAccess.Bases;

namespace MyArch.DataAccess.Repositories
{
    public class ProductsRepository : Repository<Product, int>, IProductsRepository
    {
        public ProductsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
        public Task<List<Product>> GetProductsByCategoryId(int categoryId)
        {
            return GetWhere(p => p.CategoryId == categoryId).ToListAsync();
        }
    }
}
