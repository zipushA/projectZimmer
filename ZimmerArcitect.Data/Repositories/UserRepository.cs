using Microsoft.EntityFrameworkCore;
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

        public async Task< List<User>> GetListAsync()
        {
            return await _context.DataUser.ToListAsync();
        }
        public async Task<User >GetByidAsync(int id)
        {
            return await _context.DataUser.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task< bool> PostAsync(User value)
        {
            _context.DataUser.Add(value);
            await _context.SaveChangesAsync();
            return true;
        }
        public  bool Put(int id, User value)
        {
            int index = _context.DataUser.ToList().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _context.DataUser.ToList()[index] = new User(id, value);
                return true;
            }
            return false;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var x = await GetByidAsync(id);
            if (x != null)
            {
                _context.Remove(x);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
           
        }
    }
}
