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
    public class ZimmerRepository: IZimmerRepository
    {
        private readonly DataContext _context;
        public ZimmerRepository(DataContext context) {  _context = context; }
        public async Task<IEnumerable<Zimmer>> GetAsync()
        {
            return await _context.DataZimmers
                .Include(c => c.cleaner)
                .Include(o => o.owner)
                .ToListAsync(); // המתן לרשימה של Zimmer
        }


        public async Task< Zimmer> GetByIdAsync(int id)
        {
            return await _context.DataZimmers.FirstOrDefaultAsync(x => x.Id == id);

        }

     
        public async Task< bool> PostAsync( Zimmer value)
        {
            // בדוק אם ה-ownerId קיים בטבלת DataOwners
            var ownerExists = await _context.DataOwners.AnyAsync(o => o.Id == value.OwnerId);
            if (!ownerExists)
            {
                throw new Exception("The specified owner does not exist.");
            }

            // בדוק אם ה-cleanerId קיים בטבלת DataCleaners
            var cleanerExists = await _context.DataCleaners.AnyAsync(c => c.Id == value.CleanerId);
            if (!cleanerExists)
            {
                throw new Exception("The specified cleaner does not exist.");
            }

            // הוסף את הרשומה לטבלת DataZimmers
            await _context.DataZimmers.AddAsync(value);
            await _context.SaveChangesAsync();
            return true;
            //_context.DataZimmers.Add(value);
            //await _context.SaveChangesAsync();
            //return true;
        }
        public bool Put(int id,  Zimmer value)
        {
            int index = _context.DataZimmers.ToList().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _context.DataZimmers.ToList()[index] = new Zimmer(id, value);
                return true;

            }
            return false;
        }

      
        public async Task<bool> DeleteAsync(int id)
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
