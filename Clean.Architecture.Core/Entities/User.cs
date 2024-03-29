﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    public class User
    {
        public long userId { set; get; }
        public string email { set; get; }
        public string pass { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        //reference
        public UserDetail userDetail { set; get; }
        public List<UserRole> userRoles { set; get; }
        public List<Product> products { set; get; }
    }
}
