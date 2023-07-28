using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PD4_Memory_API.Data.Models;
using PD4_Memory_API.Data.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PD4_Memory_API.Controllers
{
    [EnableCors("PolicyAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class MemoryResetController : ControllerBase
    {
        private MemoryResetRepository _memoryResetRepository;
        private IConfiguration Configuration { get; set; }
        private string? ConnectionString { get; set; }

        public MemoryResetController(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = configuration.GetConnectionString("PD4");
            _memoryResetRepository = new MemoryResetRepository() { ConnectionString = ConnectionString };
        }

        // GET: api/<Controller>
        [HttpGet]
        public IEnumerable<MemoryReset> Get()
        {
            return _memoryResetRepository.Get();
        }

        // POST api/<Controller>
        [HttpPost("{timestamp}")]
        public MemoryReset Post(string timestamp)
        {
            return _memoryResetRepository.Add(new MemoryReset() { Timestamp = timestamp});
        }

        // DELETE api/<Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _memoryResetRepository.Delete(id);
        }
    }
}
