using Entities;
using SecurityServiceInterfaces.Interfaces;
using System;
using UserRepositoryInterfaces.Interfaces;

namespace SecurityServiceImplementation {
    public class SecurityService : ISecurityService {
        private IUserRepository userRepository;

        public SecurityService(IUserRepository userRepository) {
            if (userRepository == null) throw new ArgumentNullException("userRepository");
            this.userRepository = userRepository;
            // this.Session = SessionFactory.GetSession();
        }

        public void ChangePassword(int userId, string newPassword) {
            Product user = userRepository.GetById(userId);
        }
    }
}