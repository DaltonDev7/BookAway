﻿

using System.Linq.Expressions;

namespace BookAway.Application.Interfaces.Generic
{
    public interface IBaseRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "", int? take = null, int? skip = null);
        Task<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "");
        Task Insert(TEntity entity);
        void Update(TEntity entity);
        Task Delete(int Id);
    }
}
