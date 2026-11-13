using New_Recipe_API.Models;

namespace New_Recipe_API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User Add(User user);
        User Delete(int id);
        User Edit(int id, User data);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}