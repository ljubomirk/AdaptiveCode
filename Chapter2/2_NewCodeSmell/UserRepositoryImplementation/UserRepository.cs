using UserRepositoryInterfaces.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRepositoryImplementation
{
    public class UserRepository : IUserRepository {
        private EFDbContext _context = new EFDbContext();

        public Product GetById(int productId) {
            //return new Product();
            return _context.Products.Where(p => p.ProductID == productId).FirstOrDefault();
        }
    }
}
