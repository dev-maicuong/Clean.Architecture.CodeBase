using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.Repositorys.Infratructure;
using Clean.Architecture.Infrastructure.Data.EF;
using Microsoft.EntityFrameworkCore;

namespace Clean.Architecture.Infrastructure.Repositorys.Infratructure
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly CleanArchitectureDbContext _context;
        protected readonly DbSet<T> _entities;
        public BaseRepository(CleanArchitectureDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public virtual async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public virtual async Task Delete(long id)
        {
            T entity = await GetById(id);
            _entities.Remove(entity);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public virtual async Task<T> GetById(long id)
        {
            return await _entities.FindAsync(id);
        }

        public virtual void Update(T entity)
        {
            _entities.Update(entity);
        }
    }
}
