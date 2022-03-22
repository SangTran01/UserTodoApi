using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserTodoApi.Models;
using UserTodoApi.Repositories;
using UserTodoApi.Services;

namespace UserTodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _userRepository;

        public UserController(IRepository<User> repository) { 
            _userRepository = repository;
        }

        [HttpGet("GetUsers")]
        public async Task<IActionResult> Get() {
            var res = await _userRepository.GetAllAsync();
            if (res == null) return NotFound();
            return Ok(res);
        }
    }
}
