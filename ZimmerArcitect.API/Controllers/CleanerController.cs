using Microsoft.AspNetCore.Mvc;
using ZimmerArcitect.core.DTO;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZimmerArcitect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanerController : ControllerBase
    {
        private readonly IClenerService _clenerService;
        public CleanerController(IClenerService clenerService)
        {
            _clenerService = clenerService;
        }

        // GET: api/<CleanerController>
        [HttpGet]
        public IEnumerable<DtoCleanersGet> Get()
        {
            return _clenerService.GetAll();
        }

        // GET api/<CleanerController>/5
        [HttpGet("{id}")]
        public DtoCleanersGet Get(int id)
        {
            return _clenerService.GetOne(id);
        }

        // POST api/<CleanerController>
        [HttpPost]
        public bool Post([FromBody] DtoCleanersPost value)
        {
            _clenerService.Add(value);
            return true;
        }

        // PUT api/<CleanerController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] DtoCleanersPost value)
        {
            _clenerService.update(id, value);
            return true;
        }

        // DELETE api/<CleanerController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            _clenerService.Remove(id);
            return true;
        }

    }
}
