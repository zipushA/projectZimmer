using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;

namespace ZimmerArcitect.core.Repositories
{
    public interface IOrderRepository
    {
        List<Order> Get();

       Order GetById(int id);

        bool Post(Order order);

         bool Put(int id, Order value);
         void Delete(int id);
         
        
    }
}
