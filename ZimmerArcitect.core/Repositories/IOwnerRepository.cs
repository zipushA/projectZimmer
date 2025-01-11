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
        IEnumerable<Owner> Get();
         Owner GetById(int id);
        bool Post(Owner owner);
         bool Put(int id, Owner value);
         void Delete(int id);
        
    }
}
