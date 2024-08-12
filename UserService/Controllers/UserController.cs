using Microsoft.AspNetCore.Mvc;
using UserService.Models;

namespace UserService.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly List<User> _users = new List<User>
    {
        new User { Id = 1, Username = "User1", Email = "user1@example.com" },
        new User { Id = 2, Username = "User2", Email = "user2@example.com" }
    };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_users);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            return Ok(user);
        }
    }
}
