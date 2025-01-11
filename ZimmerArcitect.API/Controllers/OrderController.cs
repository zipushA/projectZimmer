using Microsoft.AspNetCore.Mvc;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZimmerArcitect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orderService.GetAll();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _orderService.GetOne(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public bool Post([FromBody]Order value)
        {
            _orderService.Add(value);
            return true;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Order value)
        {
            _orderService.update(id, value);
            return true;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _orderService.Remove(id);
           
        }
    }
}
