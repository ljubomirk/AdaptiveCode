using _2_NewCodeSmell.Interfaces;
using _2_NewCodeSmell.Models;

namespace _2_NewCodeSmell.Infrastructure {
    public class UserRepository : IUserRepository {
        public User GetById(int userId) {
            return new User();
        }
    }
}