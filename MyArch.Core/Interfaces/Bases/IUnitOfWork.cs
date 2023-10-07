using MyArch.Core.Entities;
using MyArch.Core.Interfaces.Repositories;

namespace MyArch.Core.Interfaces.Bases
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
        public void Dispose();
        IProductsRepository Products { get; }
        IRepository<Category, int> Categories { get; }
    }
}
