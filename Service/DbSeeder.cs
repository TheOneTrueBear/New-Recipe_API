using New_Recipe_API.Repositories;
using New_Recipe_API.Models;
using New_Recipe_API.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace New_Recipe_API.Service
{
    public static class DbSeeder
    {
        public static void UserSeeder(UserRepository userRepo, APIDbContext context)
        {
            if (userRepo.includeData)
            {
                List<User> users = new List<User>()
                {
                    new User("admin", "1234"),

                    new User("user", "user1234")
                };

                context.Add(users);
                context.SaveChanges();
            
            }
        }
    }
}
