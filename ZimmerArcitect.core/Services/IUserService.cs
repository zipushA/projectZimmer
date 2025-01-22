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
       Task< List<User>> GetAllAsync();
       Task< User >GetOneAsync(int id);
       Task< bool >AddAsync(User user);
        bool update(int id, User value);
       Task<bool> RemoveAsync(int id);
    }
}
