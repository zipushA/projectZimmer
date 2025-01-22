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
    public class CleanerRepository:ICleanerRepository
    {
       private readonly DataContext _context;
       public CleanerRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Cleaner>> GetAsync()
        {
            return await _context.DataCleaners.Include(z=>z.Zimmers).ToListAsync();
        }
        public async Task<Cleaner> GetByIdAsync(int id)
        {
           return await _context.DataCleaners.FirstOrDefaultAsync(x => x.Id == id);           
        }

        
        public async Task< bool> PostAsync(Cleaner value)
        {
            _context.DataCleaners.Add(value);
            await _context.SaveChangesAsync();
            return true;
        }

       
        public async Task<bool> PutAsync(int id,  Cleaner value)
        {

            var dataCleanersList = _context.DataCleaners.ToList();
            int index = dataCleanersList.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                dataCleanersList[index] = value;
                _context.DataCleaners.Update(dataCleanersList[index]);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task <bool> DeleteAsync(int id)
        {
            var x = await GetByIdAsync(id); // ודא שאתה משתמש ב-await
            if (x != null)
            {
                _context.Remove(x);
                await _context.SaveChangesAsync(); // שומר את השינויים
                return true;
            }
            return false;
        }  
    }
}
