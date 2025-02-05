using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZimmerArcitect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public async Task< IEnumerable<Order>> Get()
        {
            return await _orderService.GetAllAsync();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task< Order> Get(int id)
        {
            return await _orderService.GetOneAsync(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<bool> Post([FromBody]Order value)
        {
            await _orderService.AddAsync(value);
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
        public async Task<bool> Delete(int id)
        {
           return await _orderService.RemoveAsync(id);
           
        }
    }
}
