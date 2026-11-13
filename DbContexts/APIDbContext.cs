using Microsoft.EntityFrameworkCore;
using New_Recipe_API.Models;
namespace New_Recipe_API.DbContexts
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
