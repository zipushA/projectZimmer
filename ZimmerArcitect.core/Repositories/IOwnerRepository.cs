using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;

namespace ZimmerArcitect.core.Repositories
{
    public interface IOwnerRepository
    {
        public Task<IEnumerable<Owner>> GetAsync();
        public Task<Owner> GetByIdAsync(int id);

        public Task<bool> PostAsync(Owner owner);
        public bool Put(int id, Owner value);

        public Task<bool> DeleteAsync(int id);
        

    }
}
