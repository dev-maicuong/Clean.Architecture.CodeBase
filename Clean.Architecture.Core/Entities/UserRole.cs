﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    public class UserRole
    {
        [ForeignKey("userId")]
        public User user { set; get; }
        [ForeignKey("roleId")]
        public Role Role { set; get; }
        public long userId { set; get; }
        public long roleId { set; get; }
    }
}
