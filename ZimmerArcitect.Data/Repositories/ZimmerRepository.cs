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
        public IEnumerable<Zimmer> Get()
        {
            return _context.DataZimmers.Include(c => c.cleaner).Include(o => o.owner);
        }

        
        public Zimmer GetById(int id)
        {
            return _context.DataZimmers.FirstOrDefault(x => x.Id == id);

        }

     
        public bool Post( Zimmer value)
        {
            _context.DataZimmers.Add(value);
            _context.SaveChanges();
            return true;
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

      
        public void Delete(int id)
        {
            var x = GetById(id);
            if (x != null)
            {
                _context.Remove(x);
            }
            _context.SaveChanges();
        }
    }
}
