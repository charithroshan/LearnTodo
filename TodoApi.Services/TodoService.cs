using TodoApi.Model;

namespace TodoApi.Services
{
    public class TodoService
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Learn C#",
                Description = "Learn C# from tutorial",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Learn bootstrap",
                Description = "Learn bootstrap from tutorial",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(7),
                Status = TodoStatus.New

            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Learn Anguler",
                Description = "Learn Anguler from tutorial",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.New

            };
            todos.Add(todo3);

            return (todos);
        }
    }
}
