using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public static class UserServices
    {
        static IUserRepository repository;

        static UserServices()
        {
            repository = new UserRepository();
        }

        public static List<User> GetAll()
        {
            return repository.GetAll();
        }

        public static User GetById(int id)
        {
            return repository.GetById(id);
        }

        public static User GetUser(string username, string password)
        {
            return repository.GetUser(username, password);
        }

        public static User Insert(User user)
        {
            return repository.Insert(user);
        }

        public static void Update(User user)
        {
            repository.Update(user);
        }

        public static void Delete(User user)
        {
            repository.Delete(user);
        }

    }
}
