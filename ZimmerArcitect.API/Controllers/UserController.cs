using Microsoft.AspNetCore.Mvc;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Services;
using ZimmerArcitect.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZimmerArcitect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task< IEnumerable<User>> Get()
        {
            return await _userService.GetAllAsync();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _userService.GetOneAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<bool> Post([FromBody] User value)
        {
            await _userService.AddAsync(value);
            return true;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
            _userService.update(id, value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
          return await _userService.RemoveAsync(id);
        }
    }
}
