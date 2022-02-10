using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Services.Authors;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        public AuthorsController(IAuthorRepository service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _service.GetAllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _service.GetAuthor(id);

            if(author == null)
                return NotFound();

            return Ok(author);
        }
        
    }
}
