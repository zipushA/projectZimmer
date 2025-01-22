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
    public interface IZimmerService
    {
        public Task<IEnumerable<DtoZimmer>> GetAllAsync();

        public Task<DtoZimmer> GetOneAsync(int id);

        public Task<bool> AddAsync(DtoZimmer zimmer);

        public bool update(int id, DtoZimmer value);

        public Task<bool> RemoveAsync(int id);
       
    }
}
