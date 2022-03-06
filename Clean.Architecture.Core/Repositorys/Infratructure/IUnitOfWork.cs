using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.Repositorys.Interfaces;

namespace Clean.Architecture.Core.Repositorys.Infratructure
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
