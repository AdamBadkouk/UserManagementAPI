using UserManagementAPI.Models;

namespace UserManagementAPI.Services
{
    public interface IUserService
    {
        Task<User?> Authenticate(string username, string password);
        Task<User> CreateUser(User user);
        Task<User?> GetUserById(int id);
        Task<List<User>> GetAllUsers();
        Task<bool> UserExists(string username, string email);
    }
}