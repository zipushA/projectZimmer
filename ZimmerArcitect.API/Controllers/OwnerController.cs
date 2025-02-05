using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZimmerArcitect.core.DTO;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZimmerArcitect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        // GET: api/<OwnerController>
        [HttpGet]
        public async Task<IEnumerable<DtoOwnerGet>> Get()
        {
            return await _ownerService.GetAllSaync();
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public async Task<DtoOwnerGet> Get(int id)
        {
            return await _ownerService.GetOneAsync(id);
        }

        // POST api/<OwnerController>
        [HttpPost]
        public async Task<bool> Post([FromBody] DtoOwnerPost value)
        {
            await _ownerService.AddAsync(value);
            return true;
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] DtoOwnerPost value)
        {
            _ownerService.update(id, value);
            return true;
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
           return await _ownerService.RemoveAsync(id);
        }
    }
}
