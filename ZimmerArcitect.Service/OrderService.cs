using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Repositories;
using ZimmerArcitect.core.Services;
using ZimmerArcitect.Data.Repositories;

namespace ZimmerArcitect.Service
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService (IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<List<Order>> GetAllAsync()
        {
            return await _orderRepository.GetAsync();
        }
        public async Task< Order> GetOneAsync(int id)
        {
            return await _orderRepository.GetByIdAsync(id);
        }
        public async Task<bool> AddAsync(Order order)
        {
           await _orderRepository.PostAsync(order);
            return true;
        }
        public bool update(int id,Order value)
        {
            _orderRepository.Put(id, value);
            return true;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            return await _orderRepository.DeleteAsync(id);
        }
    }
}
