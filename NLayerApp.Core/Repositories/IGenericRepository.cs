using System.Linq.Expressions;

namespace NLayerApp.Core.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(long id);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);
        Task AddAsync(TEntity entity);
        Task<TEntity> AddRangeAsync(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
