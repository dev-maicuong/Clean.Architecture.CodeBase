using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    public class UserDetail
    {
        public long userDetailId { set; get; }
        public DateTime createDay { set; get; }
        public DateTime updateDay { set; get; }
        //reference
        public User user { set; get; }
    }
}
