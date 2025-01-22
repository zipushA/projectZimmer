using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;

namespace ZimmerArcitect.core.Repositories
{
    public interface IZimmerRepository
    {
        public Task<IEnumerable<Zimmer>> GetAsync();

        public Task<Zimmer> GetByIdAsync(int id);
        public Task<bool> PostAsync(Zimmer value);

        public bool Put(int id, Zimmer value);
        public Task<bool> DeleteAsync(int id);
        

    }
}
