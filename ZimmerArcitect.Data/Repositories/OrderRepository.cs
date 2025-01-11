using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Repositories;

namespace ZimmerArcitect.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public List<Order> Get()
        {
            return _context.DataOrders.ToList();
        }
        public Order GetById(int id)
        {
            return _context.DataOrders.ToList().FirstOrDefault(x => x.Id == id);
        }
        public bool Post(Order order)
        {
            _context.DataOrders.Add(order);
            _context.SaveChanges();
            return true;
        }
        public bool Put(int id, Order value)
        {
            int index = _context.DataOrders.ToList().FindIndex(x => x.Id == id);
            if (index != -1 && value != null)
            {
                _context.DataOrders.ToList()[index] = new Order(id, value);
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            var x = GetById(id);
            if (x != null)
            {
                _context.Remove(x);
            }
            _context.SaveChanges();
        }

    }
}
   
