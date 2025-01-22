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
        public Task<List<Order>> GetAllAsync();

        public Task<Order> GetOneAsync(int id);

        public Task<bool> AddAsync(Order order);

        public bool update(int id, Order value);

        public Task<bool> RemoveAsync(int id);
       

    }
}
