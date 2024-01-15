using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();

            // Adding a new user
            User newUser = new User { Id = 1, Name = "John Doe" };
            userRepository.Add(newUser);

            // Getting user by ID
            User retrievedUser = userRepository.GetById(1);
            Console.WriteLine($"Retrieved User: {retrievedUser.Name}");

            // Updating user
            retrievedUser.Name = "Jane Smith";
            userRepository.Update(retrievedUser);

            // Deleting user
            userRepository.Delete(1);

            // Getting all users
            var allUsers = userRepository.GetAll();
            foreach (var user in allUsers)
            {
                Console.WriteLine($"User: {user.Name}");
            }
            Console.Read();
        }
    }
}
