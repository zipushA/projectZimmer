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
        public IEnumerable<DtoZimmer> GetAll();

        public DtoZimmer GetOne(int id);

        public bool Add(DtoZimmer zimmer);

        public bool update(int id, DtoZimmer value)
        ;
        public void Remove(int id);
        
    }
}
