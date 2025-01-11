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
        public IEnumerable<Cleaner> Get()
        {
            return _context.DataCleaners.Include(z=>z.Zimmers);
        }
        public Cleaner GetById(int id)
        {
           return _context.DataCleaners.FirstOrDefault(x => x.Id == id);
           
        }

        
        public bool Post(Cleaner value)
        {
            _context.DataCleaners.Add(value);
            _context.SaveChanges();
            return true;
        }

       
        public bool Put(int id,  Cleaner value)
        {
            int index = _context.DataCleaners.ToList().FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _context.DataCleaners.ToList()[index] = value;//new Cleaner(id, value);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

       
        public void Delete(int id)
        {
            var x=GetById(id);
            if (x != null)
            {
                _context.Remove(x);
            }
            _context.SaveChanges();
            
        }
    }
}
