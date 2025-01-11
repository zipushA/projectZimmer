using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Repositories;

namespace ZimmerArcitect.Data.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public List<User> GetList()
        {
            return _context.DataUser.ToList();
        }
        public User GetByid(int id)
        {
            return _context.DataUser.ToList().FirstOrDefault(x => x.Id == id);
        }
        public bool Post(User value)
        {
            _context.DataUser.Add(value);
            _context.SaveChanges();
            return true;
        }
        public bool Put(int id, User value)
        {
            int index = _context.DataUser.ToList().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _context.DataUser.ToList()[index] = new User(id, value);
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            var x = GetByid(id);
            if (x != null)
            {
                _context.Remove(x);
            }
            _context.SaveChanges();
        }
    }
}
