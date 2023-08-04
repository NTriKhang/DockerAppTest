using DockerApp.Data;
using DockerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger,
            AppDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return context.Users;
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return Created(nameof(Get), user);
        }
    }
}