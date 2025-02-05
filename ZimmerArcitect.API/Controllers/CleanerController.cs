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
    public class CleanerController : ControllerBase
    {
        private readonly IClenerService _clenerService;
        public CleanerController(IClenerService clenerService)
        {
            _clenerService = clenerService;
        }

        // GET: api/<CleanerController>
        [HttpGet]
        public async Task<IEnumerable<DtoCleanersGet>> Get()
        {
            return await _clenerService.GetAllAsync();
        }

        // GET api/<CleanerController>/5
        [HttpGet("{id}")]
        public async Task<DtoCleanersGet >Get(int id)
        {
            return await _clenerService.GetOneAsync(id);
        }

        // POST api/<CleanerController>
        [HttpPost]
        public async Task<bool> Post([FromBody] DtoCleanersPost value)
        {
           await _clenerService.AddAsync(value);
            return true;
        }

        // PUT api/<CleanerController>/5
        [HttpPut("{id}")]
        public async Task<bool> Put(int id, [FromBody] DtoCleanersPost value)
        {
            await _clenerService.updateAsync(id, value);
            return true;
        }

        // DELETE api/<CleanerController>/5
        [HttpDelete("{id}")]
        public async Task< bool> Delete(int id)
        {
            await _clenerService.RemoveAsync(id);
            return true;
        }

    }
}
