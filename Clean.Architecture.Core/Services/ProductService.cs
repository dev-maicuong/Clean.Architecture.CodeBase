using Clean.Architecture.Core.DTOs;
using Clean.Architecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.Repositorys.Infratructure;

namespace Clean.Architecture.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IList<ProductDto>> GetAllAsync()
        {
            var listProduct = await _unitOfWork.ProductRepository.GetAll();
            return listProduct.Select(p => new ProductDto 
            {
                productName = p.productName,
                userName = $"1"
            }).ToList();
            
        }
    }
}
