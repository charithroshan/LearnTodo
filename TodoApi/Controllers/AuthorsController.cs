using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Services.Authors;
using TodoApi.Services.ViewModels;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<AuthorViewModel>> GetAllAuthors(string? job, string? search)
        {
            
            var authors = _service.GetAllAuthors(job, search);

            var mappedAuthors = _mapper.Map<ICollection<AuthorViewModel>>(authors);

            return Ok(mappedAuthors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _service.GetAuthor(id);

            if(author == null)
                return NotFound();

            var mappedAuthor = _mapper.Map<AuthorViewModel>(author);

            return Ok();
        }
        
    }
}
