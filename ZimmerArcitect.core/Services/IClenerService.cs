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
        public IEnumerable<DtoCleanersGet> GetAll();

        public DtoCleanersGet GetOne(int id);

        public bool Add(DtoCleanersPost cleaner)
        ;
        public bool update(int id, DtoCleanersPost value);

        public void Remove(int id)
        ;
    }
}
