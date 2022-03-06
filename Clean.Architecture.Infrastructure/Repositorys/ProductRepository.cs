using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.Entities;
using Clean.Architecture.Core.Repositorys.Interfaces;
using Clean.Architecture.Infrastructure.Repositorys.Infratructure;
using Clean.Architecture.Infrastructure.Data.EF;
using Microsoft.EntityFrameworkCore;

namespace Clean.Architecture.Infrastructure.Repositorys
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(CleanArchitectureDbContext context) : base(context) {}
        public async Task<string> GetName(long id)
        {
            try
            {
                var product = await GetById(id);
                return product.productName ?? "No Name!";
            }
            catch(Exception ex)
            {
                return "Exception!";
            }
            
        }
        public override async Task<IEnumerable<Product>> GetAll()
        {
            try
            {
                return await _entities.ToListAsync();
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
