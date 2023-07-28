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
    public class CombinationFoundController : ControllerBase
    {
        private CombinationFoundRepository _combinationFoundRepository;
        private IConfiguration Configuration { get; set; }
        private string? ConnectionString { get; set; }

        public CombinationFoundController(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = configuration.GetConnectionString("PD4");
            _combinationFoundRepository = new CombinationFoundRepository() { ConnectionString = ConnectionString };
        }

        // GET: api/<Controller>
        [HttpGet]
        public IEnumerable<CombinationFound> Get()
        {
            return _combinationFoundRepository.Get();
        }

        // POST api/<Controller>
        [HttpPost("{imageId}")]
        public CombinationFound Post(int imageId)
        {
            return _combinationFoundRepository.Add(new CombinationFound() { ImageId = imageId});
        }

        // PUT api/<Controller>
        [HttpPut]
        public CombinationFound Put([FromBody] CombinationFound combinationFound)
        {
            return _combinationFoundRepository.Update(combinationFound);
        }

        // DELETE api/<Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _combinationFoundRepository.Delete(id);
        }
    }
}
