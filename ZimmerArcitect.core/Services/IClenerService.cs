using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.DTO;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Repositories;

namespace ZimmerArcitect.core.Services
{
    public interface IClenerService
    {
        public Task<IEnumerable<DtoCleanersGet>> GetAllAsync();
        
        public Task<DtoCleanersGet> GetOneAsync(int id);

        public Task<bool> AddAsync(DtoCleanersPost cleaner);

        public Task<bool> updateAsync(int id, DtoCleanersPost value);

        public Task<bool> RemoveAsync(int id);
       
    }
}
