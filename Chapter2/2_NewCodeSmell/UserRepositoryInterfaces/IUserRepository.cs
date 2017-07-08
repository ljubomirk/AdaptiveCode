using Entities;

namespace UserRepositoryInterfaces.Interfaces {
    public interface IUserRepository {
        User GetById(int userId);
    }
}
