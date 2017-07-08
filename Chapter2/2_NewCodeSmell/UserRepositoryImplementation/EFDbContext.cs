using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRepositoryImplementation {
    class EFDbContext {
        public DbSet<Product> Products { get; set; }
    }
}
