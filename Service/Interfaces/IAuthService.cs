using New_Recipe_API.Models;

namespace New_Recipe_API.Service.Interfaces
{
    public interface IAuthService
    {
        Task<User?> AuthenticateUser(string username, string password);
    }
}