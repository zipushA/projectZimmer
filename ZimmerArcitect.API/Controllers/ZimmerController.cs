using Microsoft.AspNetCore.Mvc;
using ZimmerArcitect.core.DTO;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZimmerArcitect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZimmerController : ControllerBase
    {
        private readonly IZimmerService _zimmerService;
        public ZimmerController(IZimmerService zimmerService)
        {
            _zimmerService = zimmerService;
        }

        // GET: api/<ZimmerController>
        [HttpGet]
        public async Task< IEnumerable<DtoZimmer>> Get()
        {
            return await _zimmerService.GetAllAsync();
        }

        // GET api/<ZimmerController>/5
        [HttpGet("{id}")]
        public async Task< DtoZimmer> Get(int id)
        {
            return await _zimmerService.GetOneAsync(id);
        }

        // POST api/<ZimmerController>
        [HttpPost]
        public async Task< bool> Post([FromBody] DtoZimmer value)
        {
            await _zimmerService.AddAsync(value);
            return true;
        }

        // PUT api/<ZimmerController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] DtoZimmer value)
        {
            _zimmerService.update(id, value);
            return true;
        }

        // DELETE api/<ZimmerController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
           return await _zimmerService.RemoveAsync(id);
            //return true;
        }
    }
}
