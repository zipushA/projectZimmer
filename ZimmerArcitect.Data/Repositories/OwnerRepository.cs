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
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DataContext _context;
        public OwnerRepository(DataContext context)
        {
            _context = context;
        }
        public async  Task< IEnumerable<Owner>> GetAsync()
        {
            return await _context.DataOwners.Include(z => z.zimmers).ToListAsync();
        }
        public async Task<Owner> GetByIdAsync(int id)
        {
            return await  _context.DataOwners.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<bool >PostAsync(Owner owner)
        {

            _context.DataOwners.Add(owner);
            await _context.SaveChangesAsync();
            return true;
        }
        public bool Put(int id, Owner value)
        {
            int index = _context.DataOwners.ToList().FindIndex(x => x.Id == id);
            if (index != -1 && value != null)
            {
                _context.DataOwners.ToList()[index] = new Owner(id, value);
                return true;
            }
            return false;
        }
        public async Task<bool>DeleteAsync(int id)
        {
            var x =await GetByIdAsync(id);
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
