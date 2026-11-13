using New_Recipe_API.Models;
using New_Recipe_API.Repositories.Interfaces;

namespace New_Recipe_API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>();
        private int _nextId;


        public bool includeData = true;

        public UserRepository()
        {
            if (includeData)
            {
                Add(new User("admin", "admin1234"));
                Add(new User("Joachim", "Joachim525672"));
                Add(new User("Adam", "gr212fdwe"));
            }
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User Add(User user)
        {
            user.Id = _nextId++;

            _users.Add(user);
            return user;
        }

        public User GetById(int id)
        {
            User user = _users.First(r => r.Id == id);

            return user;
        }

        public User Edit(int id, User data)
        {
            User User = GetById(id);

            User.UserName = data.UserName;
            User.Password = data.Password;

            return User;
        }

        public User Delete(int id)
        {
            User user = GetById(id);

            _users.Remove(user);

            return user;
        }
    }
}
