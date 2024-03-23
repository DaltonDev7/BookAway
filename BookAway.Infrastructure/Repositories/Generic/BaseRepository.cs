using BookAway.Application.Interfaces.Generic;
using BookAway.Domain.Entities.Common;
using BookAway.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace BookAway.Infrastructure.Repositories.Generic
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly BookAwayContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;
        public BaseRepository(BookAwayContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "", int? take = null, int? skip = null)
        {
            IQueryable<TEntity> result = _dbSet;

            if (filter != null)
                result = result.Where(filter);

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                result = result.Include(includeProperty);

            if (take.HasValue && skip.HasValue)
            {
                var pageIndex = skip.Value;
                var pageSize = take.Value;
                result = result.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }

            return await result.ToListAsync();
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter, string includeProperties = "")
        {
            IQueryable<TEntity> result = _dbSet;

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                result = result.Include(includeProperty);

            return await result.FirstOrDefaultAsync(filter);
        }

        public async Task Delete(int Id)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == Id) ?? throw new Exception("Entity not found.");
            _dbSet.Remove(entity);
        }

        public async Task Insert(TEntity entity)
        {
            entity.FechaCreacion = DateTime.Now;
            await _dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            entity.FechaModificacion = DateTime.Now;

            if (_dbContext.Entry(entity).State == EntityState.Detached)
                _dbContext.Attach(entity);

            _dbSet.Update(entity);
        }
    }

}
