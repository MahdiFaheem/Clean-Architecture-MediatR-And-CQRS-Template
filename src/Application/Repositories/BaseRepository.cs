using Application.Common.Interfaces.IDbInterfaces;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<int> AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> RemoveAsync(T entity);
    }

    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DbContext _context;

        public BaseRepository(IAppDbContext context)
        {
            _context = context.Instance;
        }

        /// <summary>
        /// Gets the DbSet of entity by setting it to context.
        /// </summary>
        protected DbSet<T> DbTable => _context.Set<T>();

        public async virtual Task<int> AddAsync(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            DbTable.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public async virtual Task<ICollection<T>> GetAllAsync()
        {
            return await DbTable.ToListAsync();
        }

        public async virtual Task<T> GetByIdAsync(int id)
        {
            return await DbTable.FindAsync(id);
        }

        public async virtual Task<int> RemoveAsync(T entity)
        {
            DbTable.Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async virtual Task<int> UpdateAsync(T entity)
        {
            entity.ModifiedAt = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
