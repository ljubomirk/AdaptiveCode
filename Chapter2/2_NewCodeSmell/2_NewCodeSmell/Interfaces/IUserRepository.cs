using _2_NewCodeSmell.Models;

namespace _2_NewCodeSmell.Interfaces {
    public interface IUserRepository {
        User GetById(int userId);
    }
}
