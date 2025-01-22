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
        public Task<List<Order>> GetAsync();
       
        public  Task<Order> GetByIdAsync(int id);
       
        public  Task<bool> PostAsync(Order order);
        
        public bool Put(int id, Order value);
        
        public  Task<bool> DeleteAsync(int id);
       
     }


    }

