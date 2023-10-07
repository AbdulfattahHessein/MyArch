using MyArch.Core.Entities;
using MyArch.Core.Interfaces.Bases;

namespace MyArch.Core.Interfaces.Repositories
{
    public interface IProductsRepository : IRepository<Product, int>
    {
        Task<List<Product>> GetProductsByCategoryId(int categoryId);
    }
}
