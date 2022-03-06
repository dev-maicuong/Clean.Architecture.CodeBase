using Clean.Architecture.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.Architecture.Core.Entities
{
    public class Product
    {
        public long productId { set; get; }
        public string productName { set; get; }
        [ForeignKey("userId")]
        public User user { set; get; }
        public long? userId { set; get; }
    }
}
