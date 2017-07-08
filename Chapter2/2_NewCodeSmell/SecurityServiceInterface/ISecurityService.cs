namespace SecurityServiceInterfaces.Interfaces {
    public interface ISecurityService {
        void ChangePassword(int userId, string newPassword);
    }
}