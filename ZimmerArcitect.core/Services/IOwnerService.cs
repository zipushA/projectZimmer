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
        public IEnumerable<DtoOwnerGet> GetAll();


        public DtoOwnerGet GetOne(int id);


        public bool Add(DtoOwnerPost owner);


        public bool update(int id, DtoOwnerPost value);


        public void Remove(int id);
        
    }
}
