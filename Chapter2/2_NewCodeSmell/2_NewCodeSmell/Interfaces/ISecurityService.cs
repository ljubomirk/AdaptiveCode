namespace _2_NewCodeSmell.Interfaces {
    public interface ISecurityService {
        void ChangePassword(int userId, string newPassword);
    }
}