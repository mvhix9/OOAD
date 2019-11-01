using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(int id);
        User GetUser(string username, string password);
        User Insert(User user);
        void Update(User user);
        void Delete(User user);
    }
}
