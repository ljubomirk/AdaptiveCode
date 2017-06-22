using _2_NewCodeSmell.Infrastructure;

namespace _2_NewCodeSmell.Models {
    public class SecurityService {
        public SecurityService() {
            // this.Session = SessionFactory.GetSession();
        }

        public void ChangePassword(int userId, string newPassword) {
            var userRepository = new UserRepository();
            User user = userRepository.GetById(userId);
        }
    }
}