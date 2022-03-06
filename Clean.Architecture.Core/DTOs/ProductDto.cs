using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.DTOs
{
    public class ProductDto
    {
        public int productId { set; get; }
        public string productName { set; get; }
        public string userName { set; get; }
        public int userId { set; get; }
    }
}
