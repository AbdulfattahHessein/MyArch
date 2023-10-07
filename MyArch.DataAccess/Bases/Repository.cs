using Microsoft.EntityFrameworkCore;
using MyArch.Core.Entities;
using MyArch.Core.Interfaces.Bases;
using System.Linq.Expressions;

namespace MyArch.DataAccess.Bases
{
    public class Repository<TEntity, Key> : IRepository<TEntity, Key>
        where Key : struct
        where TEntity : Entity<Key>
    {
        private readonly ApplicationDbContext _dbContext;

        protected readonly DbSet<TEntity> _table;
        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<TEntity>();
        }

        public TEntity? GetById(Key id)
        {
            return _table.SingleOrDefault(e => e.Id.Equals(id));
        }

        public Task<TEntity?> GetByIdAsync(Key id)
        {
            return _table.SingleOrDefaultAsync(e => e.Id.Equals(id));
        }
        private IQueryable<TEntity> Includes(IQueryable<TEntity> table, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _table;
            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);
            return query;
        }

        public List<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {

            var query = Includes(_table, includes);

            return query.ToList();
        }
        public Task<List<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = Includes(_table, includes);

            return query.ToListAsync();
        }

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> criteria, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = Includes(_table, includes);

            return query.Where(criteria);
        }

        public TEntity? GetFirst(Expression<Func<TEntity, bool>> criteria, params Expression<Func<TEntity, object>>[] includes)
        {
            return GetWhere(criteria, includes).FirstOrDefault();
        }

        public Task<TEntity?> GetFirstAsync(Expression<Func<TEntity, bool>> criteria, params Expression<Func<TEntity, object>>[] includes)
        {
            return GetWhere(criteria, includes).FirstOrDefaultAsync();
        }

        public void Insert(TEntity entity)
        {
            _table.Add(entity);
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void InsertList(IQueryable<TEntity> entities)
        {
            _table.AddRange(entities);
        }

        public async Task InsertListAsync(IQueryable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }

        public void DeleteList(IQueryable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }
    }
}
