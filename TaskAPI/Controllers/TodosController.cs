using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;

        public TodosController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var myTodos = _todoService.AllTodos(); //.Where(t => t.Id == id);

            //if(id is null) return Ok(myTodos);

            //myTodos = myTodos.Where(t => t.Id == id).ToList();

            return Ok(myTodos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var todo = _todoService.GetTodo(id);
            if(todo is null)
            {
                return NotFound();
            }

            return Ok(todo);
        }



    }
}
