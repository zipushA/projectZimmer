using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public async Task<List<Order>> GetAsync()
        {

            return await _context.DataOrders.ToListAsync();

        }
        public async Task< Order> GetByIdAsync(int id)
        {
            return await _context.DataOrders.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task< bool> PostAsync(Order order)
        {
            _context.DataOrders.Add(order);
            _context.SaveChangesAsync();
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
        public async Task<bool> DeleteAsync(int id)
        {
            var order = await _context.DataOrders.FindAsync(id);
            if (order == null)
            {
                return false; // אם לא נמצא אובייקט, מחזיר false
            }

            // מוחק את האובייקט
            _context.DataOrders.Remove(order);
            await _context.SaveChangesAsync(); // שומר את השינויים
            return true;
        }

    }
}
   
