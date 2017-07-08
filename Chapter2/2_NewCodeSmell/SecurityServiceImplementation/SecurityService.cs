using _2_NewCodeSmell.Interfaces;
using SecurityServiceInterfaces.Interfaces;
using System;

namespace SecurityServiceImplementation.Models {
    public class SecurityService : ISecurityService {
        private IUserRepository userRepository;

        public SecurityService(IUserRepository userRepository) {
            if (userRepository == null) throw new ArgumentNullException("userRepository");
            this.userRepository = userRepository;
            // this.Session = SessionFactory.GetSession();
        }

        public void ChangePassword(int userId, string newPassword) {
            //User user = userRepository.GetById(userId);
        }
    }
}