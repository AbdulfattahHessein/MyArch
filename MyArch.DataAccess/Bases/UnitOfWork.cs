using MyArch.Core.Entities;
using MyArch.Core.Interfaces.Bases;
using MyArch.Core.Interfaces.Repositories;
using MyArch.DataAccess.Repositories;

namespace MyArch.DataAccess.Bases
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IProductsRepository Products { get; }

        public IRepository<Category, int> Categories { get; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {

            _dbContext = dbContext;
            Products = new ProductsRepository(dbContext);
            Categories = new Repository<Category, int>(dbContext);
        }

        public Task<int> CommitAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
