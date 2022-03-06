using Clean.Architecture.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.Architecture.Core
{
    public class Product
    {
        public int productId { set; get; }
        public string productName { set; get; }
        [ForeignKey("userId")]
        public User user { set; get; }
        public int? userId { set; get; }
    }
}
