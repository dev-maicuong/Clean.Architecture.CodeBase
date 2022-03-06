using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.Repositorys.Infratructure;
using Clean.Architecture.Core.Repositorys.Interfaces;
using Clean.Architecture.Infrastructure.Data.EF;

namespace Clean.Architecture.Infrastructure.Repositorys.Infratructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CleanArchitectureDbContext _context;
        private readonly IProductRepository _productreposotory;
        public UnitOfWork(CleanArchitectureDbContext context)
        {
            _context = context;
        }
        public IProductRepository ProductRepository => _productreposotory ?? new ProductRepository(_context);

        public void Dispose()
        {
            if (_context != null) _context.Dispose();
        }

        public void SaveChanges() => _context.SaveChanges();

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
