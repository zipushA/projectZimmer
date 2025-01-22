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
    public interface IOwnerService
    {
        public Task<IEnumerable<DtoOwnerGet>> GetAllSaync();

        public Task<DtoOwnerGet> GetOneAsync(int id);

        public Task<bool> AddAsync(DtoOwnerPost owner);

        public bool update(int id, DtoOwnerPost value);

        public Task<bool> RemoveAsync(int id);

    }
}
