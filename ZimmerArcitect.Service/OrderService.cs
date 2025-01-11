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
        public List<Order> GetAll()
        {
            return _orderRepository.Get();
        }
        public Order GetOne(int id)
        {
            return _orderRepository.GetById(id);
        }
        public bool Add(Order order)
        {
            _orderRepository.Post(order);
            return true;
        }
        public bool update(int id,Order value)
        {
            _orderRepository.Put(id, value);
            return true;
        }
        public void Remove(int id)
        {
            _orderRepository.Delete(id);
        }
    }
}
