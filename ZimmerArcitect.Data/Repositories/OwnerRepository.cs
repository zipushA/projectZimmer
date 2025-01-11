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
        public IEnumerable<Owner> Get()
        {
            return _context.DataOwners.Include(z => z.zimmers);
        }
        public Owner GetById(int id)
        {
            return _context.DataOwners.ToList().FirstOrDefault(x => x.Id == id);
        }
        public bool Post(Owner owner)
        {

            _context.DataOwners.Add(owner);
            _context.SaveChanges();
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
