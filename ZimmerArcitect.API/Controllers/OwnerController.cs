using Microsoft.AspNetCore.Mvc;
using ZimmerArcitect.core.DTO;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZimmerArcitect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        // GET: api/<OwnerController>
        [HttpGet]
        public IEnumerable<DtoOwnerGet> Get()
        {
            return _ownerService.GetAll();
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public DtoOwnerGet Get(int id)
        {
            return _ownerService.GetOne(id);
        }

        // POST api/<OwnerController>
        [HttpPost]
        public bool Post([FromBody] DtoOwnerPost value)
        {
            _ownerService.Add(value);
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
        public void Delete(int id)
        {
            _ownerService.Remove(id);
        }
    }
}
