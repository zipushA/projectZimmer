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
        public Task<IEnumerable<Cleaner>> GetAsync();

        public Task<Cleaner> GetByIdAsync(int id);
        public Task<bool> PostAsync(Cleaner value);

        public Task<bool> PutAsync(int id, Cleaner value);
        public Task<bool> DeleteAsync(int id);
    }
}
