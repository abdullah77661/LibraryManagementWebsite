using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok("Get all users");
        }
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            return Ok($"Get user with id {id}");
        }
        [HttpPost]
        public IActionResult PostUser()
        {
            return Ok("Create a new user");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id)
        {
            return Ok($"Update user with id {id}");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            return Ok($"Delete user with id {id}");
        }
    }
}
