using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;

namespace ZimmerArcitect.core.Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetOne(int id);
        bool Add(User user);
        bool update(int id, User value);
        void Remove(int id);
    }
}
