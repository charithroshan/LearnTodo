using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Services.Todos;
using TodoApi.Services.ViewModels;
namespace TodoApi.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper;
        public TodosController(ITodoRepository repository, IMapper mapper)
        {
            _todoService = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TodoViewModel>> GetAllTodo(int authorId)
        {
            var mytodos = _todoService.AllTodos(authorId);
            var mappedTodos = _mapper.Map<ICollection<TodoViewModel>>(mytodos);
            return Ok(mappedTodos);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetTodo(int authorId, int id)
        {
            var todo = _todoService.GetTodo(authorId, id);

            if(todo == null)
                return NotFound();

            var mappedtodo = _mapper.Map<TodoViewModel>(todo);
            return Ok(mappedtodo);
        }
    }
}
