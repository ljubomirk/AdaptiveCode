using _2_NewCodeSmell.Infrastructure;
using _2_NewCodeSmell.Interfaces;

namespace _2_NewCodeSmell.Models {
    public class SecurityService {
        private IUserRepository userRepository;

        public SecurityService(IUserRepository userRepository) {
            this.userRepository = userRepository;
            // this.Session = SessionFactory.GetSession();
        }

        public void ChangePassword(int userId, string newPassword) {
            User user = userRepository.GetById(userId);
        }
    }
}