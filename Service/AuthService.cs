using New_Recipe_API.DbContexts;
using New_Recipe_API.Models;
using New_Recipe_API.Service.Interfaces;

namespace New_Recipe_API.Service
{
    public class AuthService : IAuthService
    {
        private APIDbContext _context;

        public AuthService(APIDbContext context)
        {
            _context = context;
        }

        //Add password hashing 
        public async Task<User?> AuthenticateUser(string username, string password)
        {
            User? user = _context.Users.FirstOrDefault(u => u.UserName == username);

            if (user == null)
            {
                return null;
            }
            return user;

        }
    }
}
