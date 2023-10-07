using MyArch.Core.Entities;
using System.Linq.Expressions;

namespace MyArch.Core.Interfaces.Bases
{
    public interface IRepository<T, Key>
        where Key : struct
        where T : Entity<Key>
    {


        T? GetById(Key id);
        Task<T?> GetByIdAsync(Key id);
        List<T> GetAll(params Expression<Func<T, object>>[] includes);
        Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
        T? GetFirst(Expression<Func<T, bool>> criteria, params Expression<Func<T, object>>[] includes);
        Task<T?> GetFirstAsync(Expression<Func<T, bool>> criteria, params Expression<Func<T, object>>[] includes);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> criteria, params Expression<Func<T, object>>[] includes);
        void Insert(T entity);
        Task InsertAsync(T entity);
        void InsertList(IQueryable<T> entities);
        Task InsertListAsync(IQueryable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void DeleteList(IQueryable<T> entities);
    }
}

