

using System.Linq.Expressions;

namespace BookAway.Application.Interfaces.Generic
{
    public interface IBaseRepository<TEntity>
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetAsync(int id);

        void Add(TEntity entity);
        void AddAll(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveAll(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
    }
}
