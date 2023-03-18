using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet] //method level attribute
        public IActionResult Tasks()     //can send response with status codes by using IActionResult type
        {
            var tasks = new string[] { "Task 1", "Task 2", "Task 3" };
            return Ok(tasks); 
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var somethingWentWrong = true;
            if (somethingWentWrong)
                return BadRequest();
            return Ok();
        }
    }
}
