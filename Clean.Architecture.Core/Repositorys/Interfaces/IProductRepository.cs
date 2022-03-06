using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.Entities;
using Clean.Architecture.Core.Repositorys.Infratructure;

namespace Clean.Architecture.Core.Repositorys.Interfaces
{
    public interface IProductRepository: IBaseRepository<Product>
    {
        Task<string> GetName(long id);

    }
}
