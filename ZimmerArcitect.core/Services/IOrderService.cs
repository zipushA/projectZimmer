using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Repositories;

namespace ZimmerArcitect.core.Services
{
    public interface IOrderService
    {
        public List<Order> GetAll();

        public Order GetOne(int id);

        public bool Add(Order order);

        public bool update(int id, Order value);

        public void Remove(int id);
       
    }
}
