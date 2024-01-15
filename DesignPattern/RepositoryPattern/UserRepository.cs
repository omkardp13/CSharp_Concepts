using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class UserRepository
    {
        private List<User> _users = new List<User>();

        public User GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Update(User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                // Update other properties as needed
            }
        }

        public void Delete(int id)
        {
            var userToRemove = _users.FirstOrDefault(u => u.Id == id);
            if (userToRemove != null)
            {
                _users.Remove(userToRemove);
            }
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }
    }
}
