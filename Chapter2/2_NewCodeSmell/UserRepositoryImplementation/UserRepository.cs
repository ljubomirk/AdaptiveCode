﻿using UserRepositoryInterfaces.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRepositoryImplementation
{
    public class UserRepository : IUserRepository {
        public Product GetById(int userId) {
            return new Product();
        }
    }
}
