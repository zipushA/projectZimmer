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
        public Task<List<User>> GetListAsync();

        public Task<User> GetByidAsync(int id);

        public Task<bool> PostAsync(User value);

        public bool Put(int id, User value);

        public Task<bool> DeleteAsync(int id);
        
    }
}
