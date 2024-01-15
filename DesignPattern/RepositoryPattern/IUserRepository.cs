using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    interface IUserRepository
    {
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
        IEnumerable<User> GetAll();
    }
}
