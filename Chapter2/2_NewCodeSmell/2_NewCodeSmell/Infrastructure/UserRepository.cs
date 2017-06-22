using _2_NewCodeSmell.Models;

namespace _2_NewCodeSmell.Infrastructure {
    public class UserRepository {
        public User GetById(int userId) {
            return new User();
        }
    }
}