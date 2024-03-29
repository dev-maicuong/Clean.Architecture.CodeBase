﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    public class Role
    {
        public long roleId { set; get; }
        public string roleName { set; get; }
        public string description { set; get; }
        //reference
        List<UserRole> userRoles { set; get; }
    }
}
