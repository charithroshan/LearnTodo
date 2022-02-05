using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Services;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;

        public TodosController()
        {
            _todoService = new TodoService();
        }

        [HttpGet("{Id?}")]
        public IActionResult GetTodo(int? Id)
        {
            var mytodos = _todoService.AllTodos();

            if(Id == null)
                return Ok(mytodos);
            mytodos= mytodos.Where(todo => todo.Id == Id).ToList();

            return Ok(mytodos);
        }
        
    }
}
