using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Services.Todos;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;

        public TodosController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet]
        public IActionResult GetAllTodo()
        {
            var mytodos = _todoService.AllTodos();
            return Ok(mytodos);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var myTodo = _todoService.GetTodo(id);

            if(myTodo == null)
                return NotFound();

            return Ok(myTodo);
        }
    }
}
