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
    public class ImageController : ControllerBase
    {
        private ImageRepository _imageRepository;
        private IConfiguration Configuration { get; set; }
        private string? ConnectionString { get; set; }

        public ImageController(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = configuration.GetConnectionString("PD4");
            _imageRepository = new ImageRepository() { ConnectionString = ConnectionString };
        }

        // GET: api/<Controller>
        [HttpGet]
        public IEnumerable<int> Get()
        {
            return _imageRepository.GetIdsFront();
        }

        [HttpGet("back")]
        public int GetBack()
        {
            return _imageRepository.GetIdBack();
        }

        // GET api/<Controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            byte[] data = _imageRepository.GetById(id, out string contentType);
            Response.ContentType = contentType;
            return File(data, contentType);
        }

        // GET api/<Controller>/name/myImageName
        [HttpGet("name/{name}")]
        public Image Get(string name)
        {
            return _imageRepository.GetByName(name);
        }

        // POST api/<Controller>
        [HttpPost]
        public Image Post([FromBody] Image image)
        {
            return _imageRepository.Add(image);
        }

        // PUT api/<Controller>
        [HttpPut]
        public Image Put([FromBody] Image image)
        {
            return _imageRepository.Update(image);
        }

        // DELETE api/<Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _imageRepository.Delete(id);
        }
    }
}
