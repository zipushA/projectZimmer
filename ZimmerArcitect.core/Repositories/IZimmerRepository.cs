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
        public IEnumerable <Zimmer> Get();
        public Zimmer GetById(int id);
        public bool Post(Zimmer value);
        public bool Put(int id, Zimmer value);
        public void Delete(int id);
       
    }
}
