using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;

namespace ZimmerArcitect.core.Repositories
{
    public interface ICleanerRepository
    {
        public IEnumerable<Cleaner> Get();
        
        public Cleaner GetById(int id);
        

        public bool Post(Cleaner value);

        public bool Put(int id, Cleaner value);
        public void Delete(int id);
        
    }
}
