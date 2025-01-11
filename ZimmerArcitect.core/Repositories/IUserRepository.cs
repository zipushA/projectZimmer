using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;

namespace ZimmerArcitect.core.Repositories
{
    public interface IUserRepository
    {
         List<User> GetList();
         User GetByid(int id);
         bool Post(User value);
        bool Put(int id, User value);
        void Delete(int id);
    }
}
