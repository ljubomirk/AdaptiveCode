using Entities;

namespace UserRepositoryInterfaces.Interfaces {
    public interface IUserRepository {
        Product GetById(int productId);
    }
}
