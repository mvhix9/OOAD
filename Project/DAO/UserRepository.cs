using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Common;
using System.Data.Entity;
using System.Security.Cryptography;


namespace DAO
{
    public class UserRepository : IUserRepository
    {
        private void CacheUser(User user)
        {
            UserCache.Name = user.Name;
            switch(user.RoleId)
            {
                case 1:
                    UserCache.Role = "Quản trị viên";
                    break;
                case 2:
                    UserCache.Role = "Nhân viên";
                    break;
                case 3:
                    UserCache.Role = "Bác sĩ";
                    break;
            }
        }

        public List<User> GetAll()
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                return db.Users.ToList();
            }
        }

        public User GetById(int id)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                return db.Users.Find(id);
            }
        }

        public User GetUser(string username, string password)
        {
            User user = new User();
            using (SchoolEntities db = new SchoolEntities())
            {
                user = db.Users.Where(u => u.Username.Equals(username)).FirstOrDefault();
                if (user != null)
                {
                    if (HashPassword.CompareHash(password, user.Password))
                    {
                        CacheUser(user);
                        return user;
                    }
                }
            }
            return null;
        }

        public User Insert(User user)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                db.Users.Attach(user);
                db.SaveChanges();
                return user;
            }
        }

        public void Update(User user)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                db.Users.Attach(user);
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(User user)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                db.Users.Attach(user);
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
